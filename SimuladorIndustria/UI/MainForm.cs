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
        //public List<Dias> Dias = new List<Dias>();
        public Maquinarias maquinaria1 = new Maquinarias();
        public Maquinarias maquinaria2 = new Maquinarias();
        public int ProductoHoraMaquinaria1 = 50;
        public int ProductoHoraMaquinaria2 = 40;
        public int MateriaPrima;        
        public Dias Dia = new Dias();
             

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //SimularProduccion();
        }

        public void SimularProduccion()
        {          
            if (PedidosForm.CantidadProductosFabricar != 0)
            {
                Dia.Numero++;
                maquinaria1.CantidadProducidaDia = ProductoHoraMaquinaria1 * 10;
                maquinaria2.CantidadProducidaDia = ProductoHoraMaquinaria2 * 10;

                Dia.CantidadProducida = maquinaria1.CantidadProducidaDia + maquinaria2.CantidadProducidaDia;

                if(Dia.Numero >= 30)
                {
                    if (maquinaria1.Averiada == false)
                        maquinaria1.ConocerEstadoMaquinaria();

                    if (maquinaria2.Averiada == false)
                        maquinaria2.ConocerEstadoMaquinaria();                  

                    if(maquinaria1.Averiada == true && maquinaria2.Averiada == false)
                    {
                        ProductoHoraMaquinaria1 = 0;
                        maquinaria1.CantidadDiasAveriada++;
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
                DataGridView.Rows.Add(Dia.Numero,Dia.CantidadProducida);
                PedidosForm.CantidadProductosFabricar -= Dia.CantidadProducida;
                //Thread.Sleep(5000);
            }
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            MateriaPrima = aleatorio.Next(5000, 500000);
            Timer.Enabled = true;
            //SimularProduccion();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SimularProduccion();
        }
    }
}