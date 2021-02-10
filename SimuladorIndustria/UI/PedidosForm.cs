using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorIndustria
{
    public partial class PedidosForm : Form
    {
        public static double CantidadProductosFabricar;

        public PedidosForm()
        {
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            CantidadProductosFabricar = Convert.ToInt32(CantidadProductosTextBox.Text);
            
            MainForm ventana = new MainForm();
            ventana.ShowDialog();
        }
    }
}
