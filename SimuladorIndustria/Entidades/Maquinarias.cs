using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorIndustria
{
    public class Maquinarias
    {
        public int ProductosHora { get; set; }
        public bool Averiada { get; set; }
        public bool Arreglada { get; set; }
        public double CantidadProducidaDia { get; set; }
        public int CantidadDiasAveriada { get; set; }

        public Maquinarias()
        {
            ProductosHora = 0;
            Averiada = false;
            Arreglada = false;
            CantidadProducidaDia = 0;
            CantidadDiasAveriada = 0;
        }

        public void ConocerEstadoMaquinaria()
        {
            Random aleatorio = new Random();

            if(aleatorio.Next(0, 10) <= 8)
                Averiada = false;
            else
                Averiada = true;
        }
    }
}
