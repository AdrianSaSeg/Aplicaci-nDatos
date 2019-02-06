using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionDatos
{
    public partial class FormSelec : Form
    {        
        public FormSelec()
        {
            InitializeComponent();
        }

        private void FormSelec_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'appPedidosDataSet.Customer' Puede moverla o quitarla según sea necesario.
            this.customerTableAdapter.Fill(this.appPedidosDataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCustomer.ID_cliente_seleccionado = comboBox1.SelectedValue.ToString();
            NewCustomer.nombre_cliente_seleccionado = comboBox1.Text;
            this.Close();
        }
    }
}
