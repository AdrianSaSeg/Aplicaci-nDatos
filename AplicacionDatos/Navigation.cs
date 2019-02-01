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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        /// <summary>       
        /// Abre el formulario NewCustomer como una ventana de diálogo. 
        /// </summary>
        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            Form frm = new NewCustomer();
            frm.Show();
        }

        /// <summary>       
        /// Abre el formulario FillOrCancel como una ventana de diálogo.
        /// </summary>
        private void btnGoToFillOrCancel_Click(object sender, EventArgs e)
        {
            Form frm = new FillOrCancel();
            frm.ShowDialog();
        }

        /// <summary>
        /// Cierra la aplicación (no sólo el formulario Navigation).
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
