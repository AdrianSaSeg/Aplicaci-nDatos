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

namespace AplicacionDatos
{
    public partial class NewCustomer : Form
    {        
        // Creamos las variables para almacenar el valor de la tabla IDENTITY de la base de datos.
        private int parsedCustomerID;
        private int orderID;

        public NewCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Comprueba que el textbox del nombre de cliente no está vacío.
        /// </summary>
        private bool IsCustomerNameValid()
        {
            if (textCustomerName.Text == "")
            {                
                MessageBox.Show("Por favor, introduzca un nombre.");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Comprueba que se ha enviado un ID de cliente una cantidad de pedidos.
        /// </summary>
        private bool IsOrderDataValid()
        {
            // Comprueba que el textbox del ID de cliente no está vacío.
            if (textCustomerID.Text == "")
            {               
                MessageBox.Show("Por favor, cree una cuenta de cliente antes de mandar un pedido.");
                return false;
            }            
            // Comprueba que la Cantidad de pedidos no es 0.
            else if ((numOrderAmount.Value < 1))
            {         
                MessageBox.Show("Por favor, especifique una cantidad.");
                return false;
            }
            else
            {
                // El pedido puede ser enviado.
                return true;
            }
        }

        /// <summary>       
        /// Limpia el formulario.
        /// </summary>
        private void ClearForm()
        {
            textCustomerName.Clear();
            textCustomerID.Clear();
            dtpOrderDate.Value = DateTime.Now;
            numOrderAmount.Value = 0;
            this.parsedCustomerID = 0;
        }

        /// <summary>        
        /// Crea un nuevo cliente llamando al procedimiento almacenado Sales.uspNewCustomer.
        /// </summary>
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (IsCustomerNameValid())
            {
                // Crea la conexión.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Crea un comando Sql y lo instancia como un procedimiento almacenado.
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspNewCustomer", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        
                        // Añade un parámetro de entrada para el procedimiento almacenado y especifica qué usa como valor.
                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@CustomerName"].Value = textCustomerName.Text;

                        // Añade el parámetro de salida.
                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
                        sqlCommand.Parameters["@CustomerID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            // Ejecuta el procedimiento almacenado.
                            sqlCommand.ExecuteNonQuery();
       
                            // El ID de cliente es un valor IDENTITY de la base de datos.
                            this.parsedCustomerID = (int)sqlCommand.Parameters["@CustomerID"].Value;

                            // Coloca valor del ID de cliente en el textbox de solo lectura.
                            this.textCustomerID.Text = Convert.ToString(parsedCustomerID);
                        }
                        catch
                        {
                            MessageBox.Show("El ID del cliente no ha sido devuelto. La cuenta no puede ser creada.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Llama al procedimiento almacenado Sales.uspPalceNewOrder para mandar un pedido.
        /// </summary>
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // Nos aseguramos de que la entrada requerida está presente.
            if (IsOrderDataValid())
            {
                // Crea la conexión.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Crea un comando Sql y lo instancia como un procedimiento almacenado.
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspPlaceNewOrder", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Añade el parámetro de entrada @CustomerID, el cual ha sido obtenido de uspNewCustomer.
                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
                        sqlCommand.Parameters["@CustomerID"].Value = this.parsedCustomerID;
                       
                        // Añade el parámetro de entrada @OrderDate.
                        sqlCommand.Parameters.Add(new SqlParameter("@OrderDate", SqlDbType.DateTime, 8));
                        sqlCommand.Parameters["@OrderDate"].Value = dtpOrderDate.Value;
                        
                        // Añade el parámetro de entrada @Amount (cantidad de pedidos).
                        sqlCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
                        sqlCommand.Parameters["@Amount"].Value = numOrderAmount.Value;
                      
                        // Añade el parámetro de entrada @Status (estado del pedido).
                        // Para un nuevo pedido, el estado es siempre 0 (abierto).
                        sqlCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.Char, 1));
                        sqlCommand.Parameters["@Status"].Value = "O";
                       
                        // Añade el valor devuelto por el procedimiento almacenado, el cual es el ID de pedido.
                        sqlCommand.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
                        sqlCommand.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;

                        try
                        {

                            // Abre la conexión.
                            connection.Open();

                            // Ejecuta el procedimiento almacenado.
                            sqlCommand.ExecuteNonQuery();

                            // Muestra el numero de pedidos.
                            this.orderID = (int)sqlCommand.Parameters["@RC"].Value;
                            MessageBox.Show("El número de pedido " + this.orderID + " ha sido entregado.");
                        }
                        catch
                        {
                            MessageBox.Show("El pedido no puede ser mandado.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Limpia los datos del formulario para que se pueda crear otra cuenta.
        /// </summary>
        private void btnAddAnotherAccount_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// Cierra la ventana del formulario.
        /// </summary>
        private void btnAddFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
