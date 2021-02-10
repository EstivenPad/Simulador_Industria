using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimuladorIndustria
{
    public partial class MainForm : Form
    {
        Random aleatorio = new Random();
        public Maquinarias maquinaria1 = new Maquinarias();
        public Maquinarias maquinaria2 = new Maquinarias();
        public int ProductoHoraMaquinaria1 = 50;
        public int ProductoHoraMaquinaria2 = 40;
        public int MateriaPrima;        
        public Dias Dias = new Dias();
             
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void SimularProduccion()
        {          
            if (PedidosForm.CantidadProductosFabricar != 0)
            {
                Dias.Numero++;
                maquinaria1.CantidadProducidaDia = ProductoHoraMaquinaria1 * 10;
                maquinaria2.CantidadProducidaDia = ProductoHoraMaquinaria2 * 10;

                Dias.CantidadProducida = maquinaria1.CantidadProducidaDia + maquinaria2.CantidadProducidaDia;

                if(Dias.Numero >= 30)
                {
                    if (maquinaria1.Averiada == false)
                        maquinaria1.ConocerEstadoMaquinaria();

                    if (maquinaria2.Averiada == false)
                        maquinaria2.ConocerEstadoMaquinaria();                  

                    if(maquinaria1.Averiada == true && maquinaria2.Averiada == false)
                    {
                        ProductoHoraMaquinaria1 = 0;
                        maquinaria1.CantidadDiasAveriada++;

                        maquinaria2.CantidadProducidaDia *= 0.20;


                    }

                }

                //***************Maquinaria 1 Arreglada************************
                if (maquinaria1.CantidadDiasAveriada == 3)
                {
                    maquinaria1.CantidadDiasAveriada = 0;
                    maquinaria1.Averiada = false;
                    ProductoHoraMaquinaria1 = 50;
                }
                else
                {

                }
                //***************************************

                //Dias.Add(Dia);
                DataGridView.Rows.Add(Dias.Numero, maquinaria1.CantidadProducidaDia, maquinaria2.CantidadProducidaDia, Dias.CantidadProducida);
                DataGridView.FirstDisplayedScrollingRowIndex = DataGridView.RowCount - 1;
                PedidosForm.CantidadProductosFabricar -= Dias.CantidadProducida;
                
            }
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            MateriaPrima = aleatorio.Next(5000, 500000);
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SimularProduccion();
        }
    }
}