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
        public Dias Dias = new Dias();
        public double MateriaPrima;
        public int DiasAveriadaM1 = 1, DiasAveriadaM2 = 1;
        public int OpcionElegida;
        public int probabilidad = 1;
             
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MateriaPrima = aleatorio.Next(5000, 500000);
            maquinaria1.ProductosHora = 50;
            maquinaria2.ProductosHora = 40;
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SimularProduccion();
        }

        public void SimularProduccion()
        {
            if (PedidosForm.CantidadProductosFabricar > 0)
            {
                Dias.Numero++;
                maquinaria1.CantidadProducidaDia = maquinaria1.ProductosHora * 10;
                maquinaria2.CantidadProducidaDia = maquinaria2.ProductosHora * 10;

                Dias.CantidadProducida = maquinaria1.CantidadProducidaDia + maquinaria2.CantidadProducidaDia;
                Dias.CantidadProducidaALaFecha += Dias.CantidadProducida;
                
                if (Dias.Numero >= 30)//Si pasó el mes
                {
                    //Determinar probabilidad de que se dañe una maquina
                    if (maquinaria1.Averiada == false)
                        maquinaria1.ConocerEstadoMaquinaria();

                    if (maquinaria2.Averiada == false)
                       maquinaria2.ConocerEstadoMaquinaria();

                    /*if (probabilidad == 1)
                    {
                        maquinaria2.Averiada = true;
                        probabilidad = 2;
                    }*/

                    //----------------------------------------Maquina 1 averiada----------------------------------------//
                    if (maquinaria1.Averiada == true && maquinaria2.Averiada == false)
                    {
                        maquinaria1.ProductosHora = 0;

                        if (maquinaria1.CantidadDiasAveriada == 0)
                        {
                            M1Averiada.Visible = true;
                            maquinaria1.IdentificarDispobilidadPieza();

                            if (maquinaria1.PiezaDisponible == true)
                                DiasAveriadaM1 = 2;
                            else
                                DiasAveriadaM1 = 3;
                            OpcionElegida = aleatorio.Next(0, 1);//Determinar metodo para reponer producción 
                        }
                        maquinaria1.CantidadDiasAveriada++;
                        maquinaria2.DiasReponerProduccion++;

                        if (maquinaria2.DiasReponerProduccion >= 1)
                            maquinaria2.DiasReponerProduccion++;

                        //Si no hay repuestos
                        if (DiasAveriadaM1 == 3)
                        {
                            //MessageBox.Show("¡Se tardará 3 días reparar la máquina 1!", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (maquinaria2.DiasReponerProduccion <= 19)//En 19 dias repone la producción
                            {
                                if (OpcionElegida == 0)//Se aumenta la cantidad de horas trabajadas
                                {
                                    maquinaria2.CantidadProducidaDia = maquinaria2.ProductosHora * 12;
                                }
                                else//Se aumenta en un 20% la productividad de la maquina
                                {
                                    maquinaria2.CantidadProducidaDia *= 0.20;
                                }

                                if (maquinaria2.DiasReponerProduccion++ == 19)
                                    maquinaria2.DiasReponerProduccion = 0;
                            }
                        }
                        //Si hay repuestos
                        else if (DiasAveriadaM1 == 2)
                        {
                            if (maquinaria2.DiasReponerProduccion <= 13)//En 13 dias repone la produccion
                            {
                                if (OpcionElegida == 0)//Se aumenta la cantidad de horas trabajadas
                                {
                                    maquinaria2.CantidadProducidaDia = maquinaria2.ProductosHora * 12;
                                }
                                else//Se aumenta en un 20% la productividad de la maquina
                                {
                                    maquinaria2.CantidadProducidaDia *= 0.20;
                                }

                                if (maquinaria2.DiasReponerProduccion++ == 13)
                                    maquinaria2.DiasReponerProduccion = 0;
                            }
                        }
                    }
                    //--------------------------------------------------------------------------------------------------//

                    //----------------------------------------Maquina 2 averiada----------------------------------------//
                    if (maquinaria2.Averiada == true && maquinaria1.Averiada == false)
                    {
                        maquinaria2.ProductosHora = 0;

                        if (maquinaria2.CantidadDiasAveriada == 0)
                        {
                            M2Averiada.Visible = true;
                            maquinaria2.IdentificarDispobilidadPieza();
                            if (maquinaria2.PiezaDisponible == true)
                                DiasAveriadaM2 = 2;
                            else
                                DiasAveriadaM2 = 3;
                            OpcionElegida = aleatorio.Next(0, 1);//Determinar metodo para reponer produccion 
                        }
                        maquinaria2.CantidadDiasAveriada++;
                        maquinaria1.DiasReponerProduccion++;

                        if (maquinaria1.DiasReponerProduccion >= 1)
                            maquinaria1.DiasReponerProduccion++;

                        //Si no hay repuestos
                        if (DiasAveriadaM2 == 3)
                        {
                            if (maquinaria1.DiasReponerProduccion++ <= 12)//En 12 dias repone la produccion
                            {
                                if (OpcionElegida == 0)//Se aumenta la cantidad de horas trabajadas
                                {
                                    maquinaria1.CantidadProducidaDia = maquinaria1.ProductosHora * 12;
                                }
                                else//Se aumenta en un 20% la productividad de la maquina
                                {
                                    maquinaria1.CantidadProducidaDia *= 0.20;
                                }

                                if (maquinaria1.DiasReponerProduccion++ == 12)
                                    maquinaria1.DiasReponerProduccion = 0;
                            }
                        }
                        //Si hay repuestos
                        else if (DiasAveriadaM2 == 2)
                        {
                            if (maquinaria1.DiasReponerProduccion++ <= 8)//En 8 dias repone la produccion
                            {
                                if (OpcionElegida == 0)//Se aumenta la cantidad de horas trabajadas
                                {
                                    maquinaria1.CantidadProducidaDia = maquinaria1.ProductosHora * 12;
                                }
                                else//Se aumenta en un 20% la productividad de la maquina
                                {
                                    maquinaria1.CantidadProducidaDia *= 0.20;
                                }

                                if (maquinaria1.DiasReponerProduccion++ == 8)
                                    maquinaria1.DiasReponerProduccion = 0;
                            }
                        }
                    }
                }
                //--------------------------------------------------------------------------------------------------//

                //-----------------Reincorporar maquinas arregladas-----------------//
                if (maquinaria1.CantidadDiasAveriada == DiasAveriadaM1)//Maquina 1
                {
                    maquinaria1.CantidadDiasAveriada = 0;
                    maquinaria1.ProductosHora = 50;
                    maquinaria1.Averiada = false;
                    M1Averiada.Visible = false;
                }
                if (maquinaria2.CantidadDiasAveriada == DiasAveriadaM2)//Maquina 2
                {
                    maquinaria2.CantidadDiasAveriada = 0;
                    maquinaria2.ProductosHora = 40;
                    maquinaria2.Averiada = false;
                    M2Averiada.Visible = false;
                }

                PedidosForm.CantidadProductosFabricar -= Dias.CantidadProducida;
                MateriaPrima -= Dias.CantidadProducida;

                if (MateriaPrima < 900)
                {
                    MessageBox.Show("¡Queda poca materia prima en el inventario, se recomienda reabastecerse!", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Cargar datos al data grid
                DataGridView.Rows.Add(Dias.Numero, maquinaria1.CantidadProducidaDia, maquinaria2.CantidadProducidaDia, Dias.CantidadProducida, Dias.CantidadProducidaALaFecha);
                DataGridView.FirstDisplayedScrollingRowIndex = DataGridView.RowCount - 1;

            }
            else
                Timer.Enabled = false;//Termina la ejecucion
        }
    }
}