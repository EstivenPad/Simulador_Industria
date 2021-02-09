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
    public partial class MainForm : Form
    {
        Random aleatorio = new Random();
        public Maquinarias maquinaria1 = new Maquinarias();
        public Maquinarias maquinaria2 = new Maquinarias();
        public int ProductoHoraMaquinaria1 = 50;
        public int ProductoHoraMaquinaria2 = 40;
             
        public int MateriaPrima;        
        public List<Dias> Dia = new List<Dias>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SimularProduccion();
        }

        public void SimularProduccion()
        {
            MateriaPrima = aleatorio.Next(5000, 500000);
            Dias Nodo = new Dias();            

            while (PedidosForm.CantidadProductosFabricar != 0)
            {
                Nodo.Dia++;
                maquinaria1.CantidadProducidaDia = ProductoHoraMaquinaria1 * 10;
                maquinaria2.CantidadProducidaDia = ProductoHoraMaquinaria2 * 10;

                Nodo.CantidadProducida = maquinaria1.CantidadProducidaDia + maquinaria2.CantidadProducidaDia;

                if(Nodo.Dia > 30)
                {
                    if (maquinaria1.Averiada == false)
                        maquinaria1.ConocerEstadoMaquinaria();

                    if (maquinaria2.Averiada == false)
                        maquinaria2.ConocerEstadoMaquinaria();                  

                    if(maquinaria1.Averiada == true && maquinaria2.Averiada == false)
                    {
                        ProductoHoraMaquinaria1 = 0;
                        //maquinaria1.CantidadDiasAveriada++;
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

                Dia.Add(Nodo);
            }
        }
    }
}