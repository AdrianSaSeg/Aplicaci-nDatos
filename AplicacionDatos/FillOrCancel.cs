using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace AplicacionDatos
{
    public partial class FillOrCancel : Form
    {
        // Crea una variable para almacenar el valor del ID de pedido. 
        private int parsedOrderID;
        private int parsedClienteID;

        public FillOrCancel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Comprueba que hay un ID de pedido y contiene caracteres válidos. 
        /// </summary>
        private bool IsOrderIDValid()
        {
            // Comprueba que el text box de ID de pedido no esté vacío.
            if (textOrderID.Text == "")
            {
                MessageBox.Show("Por favor, especifique el ID del pedido.");
                return false;
            }
           
            // Comprueba que no hay caracteres que no sean enteros.
            else if (Regex.IsMatch(textOrderID.Text, @"^\D*$"))
            {
                // Show message and clear input.
                MessageBox.Show("El ID de pedido solo puede contener números.");
                textOrderID.Clear();
                return false;
            }
            else
            {
                // Convierte el texto del text box a entero para mandarlo a la base de datos.
                parsedOrderID = Int32.Parse(textOrderID.Text);
                return true;
            }
        }

        private bool IsClientIDValid()
        {
            // Comprueba que el combobox de ID de cliente no esté vacío.
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Por favor, especifique el ID del pedido.");
                return false;
            }
          
            else
            {
                // Convierte el texto del text box a entero para mandarlo a la base de datos.
                parsedClienteID = (int)comboBox1.SelectedValue;
                return true;
            }
        }
        /// <summary>
        /// Ejecuta una orden t-SQL SELECT para obtener datos de pedido de
        /// un ID de pedido específico, después lo muestra en el DataGridView del formulario.
        /// </summary>
        private void btnFindByOrderID_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Define una cadena de consulta t-SQL que tiene un parámetro para el ID de pedido.
                    //const string sql = "SELECT * FROM AppPedidos.Orders WHERE orderID = @orderID";

                    // Crea un objeto SqlCommand usando un procedimineto almacenado.
                   // using (SqlCommand sqlCommand = new SqlCommand("AppPedidos.MostrarPedido", connection))
                    using (SqlCommand sqlCommand = new SqlCommand("AppPedidos.MostrarPedido", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Define el parámetro @orderID y le establece un valor.
                        sqlCommand.Parameters.Add(new SqlParameter("@ID_Pedido", SqlDbType.Int));
                        sqlCommand.Parameters["@ID_Pedido"].Value = parsedOrderID;
                        
                        try
                        {
                            connection.Open();

                            //////// UPDATE, ALMACENO LOS DATOS EN UNA LISTA: List<Orders>////////

                            // Creo la lista
                            List<Orders> lista_orders = new List<Orders>();

                            // Ejecuta la consulta con ExecuteReader().
                            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                            {
                                /* // Crea un DataTable para guardar los datos recogidos.
                                 DataTable dataTable = new DataTable();

                                 // Carga los datos desde el SqlDataReader en el DataTable.
                                 dataTable.Load(dataReader);

                                 // Muestra los datos del DataTable en el DataGridView.
                                 this.dgvCustomerOrders.DataSource = dataTable; */


                                // Mientras lee los datos del SqlDataReader, añade sus elementos a la lista
                                while (dataReader.Read())
                                {
                                    lista_orders.Add(new Orders()
                                    {
                                        CustomerID = dataReader.GetInt32(dataReader.GetOrdinal("CustomerID")),
                                        OrderID = dataReader.GetInt32(dataReader.GetOrdinal("OrderID")),
                                        OrderDate = dataReader.GetDateTime(dataReader.GetOrdinal("OrderDate")),
                                        FilledDate = (dataReader["FilledDate"] == DBNull.Value ? (DateTime?)null : (DateTime?)dataReader["FilledDate"]),
                                        Status = dataReader.GetString(dataReader.GetOrdinal("Status")),
                                        Amount = dataReader.GetInt32(dataReader.GetOrdinal("Amount"))
                                    });

                                }
                                // Los añade al datagrid
                                this.dgvCustomerOrders.DataSource = lista_orders;

                                // Cierra el SqlDataReader.
                                dataReader.Close();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("El pedido solicitado puede no haber sido cargado en el formulario.");
                        }
                        finally
                        {
                            // Cierra la conexión.
                            connection.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Cancela un pedido llamando al procedimiento uspCancelOrder, 
        /// almacenado en la base de datos.
        /// </summary>
        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                // Crea la conexión.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Crea el objeto SqlCommand y lo instancia como un procedimiento almacenado.
                    using (SqlCommand sqlCommand = new SqlCommand("AppPedidos.uspCancelOrder", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Añade el parámetro de entrada ID de pedido para el procedimiento almacenado.
                        sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                        sqlCommand.Parameters["@orderID"].Value = parsedOrderID;

                        try
                        {
                            // Abre la conexión.
                            connection.Open();

                            // Lanza el comando para ejecutar el procedimiento almacenado.
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("La operación de cancelar no ha sido completada.");
                        }
                        finally
                        {
                            // Cierra la coenxión.
                            connection.Close();
                        }
                    }
                }
            }
        }

        /// <summary>        
        /// Rellena un pedido llamando al procedimiento almacenado
        /// uspFillOrder guardado en la base de datos.
        /// </summary>
        private void btnFillOrder_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                // Crea la conexión.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Crea un SqlCommand y lo instancia como un procedimiento almacenado.
                    using (SqlCommand sqlCommand = new SqlCommand("AppPedidos.uspFillOrder", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Añade el parámetro de entrada ID de pedido para el procedimiento almacenado.
                        sqlCommand.Parameters.Add(new SqlParameter("@orderID", SqlDbType.Int));
                        sqlCommand.Parameters["@orderID"].Value = parsedOrderID;

                        // Añade el parámetro de entrada DateTime ya relleno para el procedimiento almacenado.
                        sqlCommand.Parameters.Add(new SqlParameter("@FilledDate", SqlDbType.DateTime, 8));
                        sqlCommand.Parameters["@FilledDate"].Value = dtpFillDate.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@Saldo_Error", SqlDbType.Int));
                        sqlCommand.Parameters["@Saldo_Error"].Direction = ParameterDirection.Output;
                        

                        try
                        {
                            connection.Open();

                            // Ejecuta el procedimiento almacenado.
                            sqlCommand.ExecuteNonQuery();

                            int codigo_error = (int)sqlCommand.Parameters["@Saldo_Error"].Value;

                            if (codigo_error != 1)
                            {
                                MessageBox.Show("Pedido Confirmado");
                            }
                            else
                            {
                                MessageBox.Show("El saldo es insuficiente");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("La operación de rellenado no ha sido completada.");
                        }
                        finally
                        {
                            // Cierra la conexión.
                            connection.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Cierra el formulario.
        /// </summary>
        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillOrCancel_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'appPedidosDataSet.Customer' Puede moverla o quitarla según sea necesario.
            this.customerTableAdapter.Fill(this.appPedidosDataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsClientIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {

                    using (SqlCommand sqlCommand = new SqlCommand("AppPedidos.MostrarPedidosPorCliente", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@ID_Cliente", SqlDbType.Int));
                        sqlCommand.Parameters["@ID_Cliente"].Value = parsedClienteID;
                        try
                        {
                            connection.Open();

                            /////// ALMACENO LOS DATOS EN UNA LISTA: List<Orders>////////

                            // Creo la lista
                            List<Orders> lista_orders = new List<Orders>();

                            // Ejecuta la consulta con ExecuteReader().
                            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                            {

                                // Mientras lee los datos del SqlDataReader, añade sus elementos a la lista
                                while (dataReader.Read())
                                {
                                    lista_orders.Add(new Orders()
                                    {
                                        CustomerID = dataReader.GetInt32(dataReader.GetOrdinal("CustomerID")),
                                        OrderID = dataReader.GetInt32(dataReader.GetOrdinal("OrderID")),
                                        OrderDate = dataReader.GetDateTime(dataReader.GetOrdinal("OrderDate")),
                                        FilledDate = (dataReader["FilledDate"] == DBNull.Value ? (DateTime?)null : (DateTime?)dataReader["FilledDate"]),
                                        Status = dataReader.GetString(dataReader.GetOrdinal("Status")),
                                        Amount = dataReader.GetInt32(dataReader.GetOrdinal("Amount"))
                                    });

                                }
                                // Los añade al datagrid
                                this.dgvCustomerOrders.DataSource = lista_orders;

                                // Cierra el SqlDataReader.
                                dataReader.Close();
                            }

                        }
                        catch
                        {
                            MessageBox.Show("El pedido solicitado puede no haber sido cargado en el formulario.");
                        }
                        finally
                        {
                            // Cierra la conexión.
                            connection.Close();
                        }
                    }
                }
            }
            
        }
    }
}