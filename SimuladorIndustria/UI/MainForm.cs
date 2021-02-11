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
        public double MateriaPrima, CantidadProductosFabricar;
        public int DiasAveriadaM1 = 1, DiasAveriadaM2 = 1;
        public int OpcionElegida;
        public string Ninguno = "Ninguno";
        public string AumentoHoras = "Aumento de horas";
        public string AumentoPorciento = "Aumento a un 20% de la productividad";
        public int probabilidad = 1;
             
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CantidadProductosFabricar = aleatorio.Next(40000, 500000);
            MateriaPrima = aleatorio.Next(900, (int)CantidadProductosFabricar);

            MateriaPrimaTextBox.Text = Convert.ToString(MateriaPrima);
            CantidadProducirTextBox.Text = Convert.ToString(CantidadProductosFabricar);

            maquinaria1.ProductosHora = 50;
            maquinaria2.ProductosHora = 40;
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = true;
        }

        private void DetenerButton_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SimularProduccion();
        }

        public void SimularProduccion()
        {

            if (CantidadProductosFabricar > 0)
            {
                if (MateriaPrima > 900)// Si hay materia prima
                {
                    Timer.Interval = 1000;
                    Dias.Numero++;
                    MateriaPrimaLb.Visible = false;
                    maquinaria1.CantidadProducidaDia = maquinaria1.ProductosHora * 10;
                    maquinaria2.CantidadProducidaDia = maquinaria2.ProductosHora * 10;
                    maquinaria1.MetodoAumentoProduccion = Ninguno;
                    maquinaria2.MetodoAumentoProduccion = Ninguno;

                    if (Dias.Numero >= 30)//Si pasó el mes
                    {
                        //Determinar probabilidad de que se dañe una maquina
                        /*if (maquinaria1.Averiada == false)
                            maquinaria1.ConocerEstadoMaquinaria();

                        if (maquinaria2.Averiada == false)
                            maquinaria2.ConocerEstadoMaquinaria();*/

                        if (probabilidad == 1)
                        {
                            maquinaria2.Averiada = true;
                            probabilidad = 2;
                        }

                        //----------------------------------------Maquina 1 averiada----------------------------------------//
                        if (maquinaria1.Averiada == true && maquinaria2.Averiada == false)
                        {
                            Timer.Interval = 2000;
                            Maquina1Lb.Visible = true;
                            maquinaria1.CantidadProducidaDia = 0;

                            if (maquinaria1.CantidadDiasAveriada == 0)
                            {
                                M1Averiada.Visible = true;
                                maquinaria1.IdentificarDispobilidadPieza();

                                if (maquinaria1.PiezaDisponible == true)
                                    DiasAveriadaM1 = 2;
                                else
                                    DiasAveriadaM1 = 3;
                                OpcionElegida = aleatorio.Next(0, 1);//Determinar metodo para reponer producción 
                                maquinaria1.AumentarProduccion = true;
                            }
                            maquinaria1.CantidadDiasAveriada++;
                        }

                        if (maquinaria1.AumentarProduccion == true)//Si hay que aumentar la produccion
                        {
                            maquinaria2.DiasReponerProduccion++;
                            //Si no hay repuestos
                            if (DiasAveriadaM1 == 3)
                            {
                                if (maquinaria1.Averiada == true)
                                    NoHayRepuestosLb.Visible = true;

                                Timer.Interval = 2000;
                                if (maquinaria2.DiasReponerProduccion <= 19)//En 19 dias repone la producción
                                {
                                    if (OpcionElegida == 0)//Se aumenta la cantidad de horas trabajadas
                                    {
                                        maquinaria2.MetodoAumentoProduccion = AumentoHoras;
                                        maquinaria2.CantidadProducidaDia = maquinaria2.ProductosHora * 12;
                                    }
                                    else//Se aumenta en un 20% la productividad de la maquina
                                    {
                                        maquinaria2.MetodoAumentoProduccion = AumentoPorciento;
                                        maquinaria2.CantidadProducidaDia *= 0.20;
                                    }

                                    if (maquinaria2.DiasReponerProduccion++ == 19)
                                    {
                                        maquinaria2.DiasReponerProduccion = 0;
                                        maquinaria1.AumentarProduccion = false;
                                    }
                                }
                            }
                            //Si hay repuestos
                            else if (DiasAveriadaM1 == 2)
                            {
                                if (maquinaria1.Averiada == true)
                                    HayRepuestosLb.Visible = true;

                                Timer.Interval = 2000;
                                if (maquinaria2.DiasReponerProduccion <= 13)//En 13 dias repone la produccion
                                {
                                    if (OpcionElegida == 0)//Se aumenta la cantidad de horas trabajadas
                                    {
                                        maquinaria2.MetodoAumentoProduccion = AumentoHoras;
                                        maquinaria2.CantidadProducidaDia = maquinaria2.ProductosHora * 12;
                                    }
                                    else//Se aumenta en un 20% la productividad de la maquina
                                    {
                                        maquinaria2.MetodoAumentoProduccion = AumentoPorciento;
                                        maquinaria2.CantidadProducidaDia *= 0.20;
                                    }

                                    if (maquinaria2.DiasReponerProduccion++ == 13)
                                    {
                                        maquinaria2.DiasReponerProduccion = 0;
                                        maquinaria1.AumentarProduccion = false;
                                    }
                                }
                            }
                        }

                        //--------------------------------------------------------------------------------------------------//

                        //----------------------------------------Maquina 2 averiada----------------------------------------//
                        if (maquinaria2.Averiada == true && maquinaria1.Averiada == false)
                        {
                            Timer.Interval = 2000;
                            Maquina2Lb.Visible = true;
                            maquinaria2.CantidadProducidaDia = 0;

                            if (maquinaria2.CantidadDiasAveriada == 0)
                            {
                                M2Averiada.Visible = true;
                                maquinaria2.IdentificarDispobilidadPieza();
                                if (maquinaria2.PiezaDisponible == true)
                                    DiasAveriadaM2 = 2;
                                else
                                    DiasAveriadaM2 = 3;
                                OpcionElegida = aleatorio.Next(0, 1);//Determinar metodo para reponer produccion 
                                maquinaria2.AumentarProduccion = true;
                            }
                            maquinaria2.CantidadDiasAveriada++;
                        }

                        if (maquinaria2.AumentarProduccion == true)//Si hay que aumentar la produccion
                        {
                            maquinaria1.DiasReponerProduccion++;
                            //Si no hay repuestos
                            if (DiasAveriadaM2 == 3)
                            {
                                if (maquinaria2.Averiada == true)
                                    NoHayRepuestosLb.Visible = true;

                                Timer.Interval = 2000;
                                if (maquinaria1.DiasReponerProduccion <= 12)//En 12 dias repone la produccion
                                {
                                    if (OpcionElegida == 0)//Se aumenta la cantidad de horas trabajadas
                                    {
                                        maquinaria1.MetodoAumentoProduccion = AumentoHoras;
                                        maquinaria1.CantidadProducidaDia = maquinaria1.ProductosHora * 12;
                                    }
                                    else//Se aumenta en un 20% la productividad de la maquina
                                    {
                                        maquinaria1.MetodoAumentoProduccion = AumentoPorciento;
                                        maquinaria1.CantidadProducidaDia *= 0.20;
                                    }

                                    if (maquinaria1.DiasReponerProduccion == 12)
                                    {
                                        maquinaria1.DiasReponerProduccion = 0;
                                        maquinaria2.AumentarProduccion = false;
                                    }
                                }
                            }
                            //Si hay repuestos
                            else if (DiasAveriadaM2 == 2)
                            {
                                if (maquinaria2.Averiada == true)
                                    HayRepuestosLb.Visible = true;

                                Timer.Interval = 2000;
                                if (maquinaria1.DiasReponerProduccion <= 8)//En 8 dias repone la produccion
                                {
                                    if (OpcionElegida == 0)//Se aumenta la cantidad de horas trabajadas
                                    {
                                        maquinaria1.MetodoAumentoProduccion = AumentoHoras;
                                        maquinaria1.CantidadProducidaDia = maquinaria1.ProductosHora * 12;
                                    }
                                    else//Se aumenta en un 20% la productividad de la maquina
                                    {
                                        maquinaria1.MetodoAumentoProduccion = AumentoPorciento;
                                        maquinaria1.CantidadProducidaDia *= 0.20;
                                    }

                                    if (maquinaria1.DiasReponerProduccion == 8)
                                    {
                                        maquinaria1.DiasReponerProduccion = 0;
                                        maquinaria2.AumentarProduccion = false;
                                    }
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
                        Maquina1Lb.Visible = false;
                        HayRepuestosLb.Visible = false;
                        NoHayRepuestosLb.Visible = false;
                    }
                    if (maquinaria2.CantidadDiasAveriada == DiasAveriadaM2)//Maquina 2
                    {
                        maquinaria2.CantidadDiasAveriada = 0;
                        maquinaria2.ProductosHora = 40;
                        maquinaria2.Averiada = false;
                        M2Averiada.Visible = false;
                        Maquina2Lb.Visible = false;
                        HayRepuestosLb.Visible = false;
                        NoHayRepuestosLb.Visible = false;
                    }

                    CantidadProductosFabricar -= Dias.CantidadProducida;
                    Dias.CantidadProducida = maquinaria1.CantidadProducidaDia + maquinaria2.CantidadProducidaDia;
                    Dias.CantidadProducidaALaFecha += Dias.CantidadProducida;
                    MateriaPrima -= Dias.CantidadProducida;
                    MateriaPrimaTextBox.Text = Convert.ToString(MateriaPrima);
                    CantidadProducirTextBox.Text = Convert.ToString(CantidadProductosFabricar);

                    //Cargar datos al data grid
                    DataGridView.Rows.Add(Dias.Numero, maquinaria1.CantidadProducidaDia, maquinaria2.CantidadProducidaDia, Dias.CantidadProducida, Dias.CantidadProducidaALaFecha, maquinaria1.MetodoAumentoProduccion, maquinaria2.MetodoAumentoProduccion);
                    DataGridView.FirstDisplayedScrollingRowIndex = DataGridView.RowCount - 1;
                }
                else//Si queda poca materia prima
                {
                    MateriaPrimaLb.Visible = true;
                    Timer.Interval = 3000;

                    if (CantidadProductosFabricar > 900)
                    {
                        MateriaPrima = aleatorio.Next(900, (int)CantidadProductosFabricar);
                    }
                    else
                    {
                        MateriaPrima += 900;
                    }
                }
            }
            else//Si se acaban los pedidos
            {
                Timer.Enabled = false;//Termina la ejecucion
                this.Close();
            }  
        }
    }
}