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
        public bool PiezaDisponible { get; set; }
        public double CantidadProducidaDia { get; set; }
        public int CantidadDiasAveriada { get; set; }
        public int DiasReponerProduccion { get; set; }
        public Maquinarias()
        {
            ProductosHora = 0;
            Averiada = false;
            Arreglada = false;
            PiezaDisponible = false;
            CantidadProducidaDia = 0;
            CantidadDiasAveriada = 0;
            DiasReponerProduccion = 0;
        }

        public void ConocerEstadoMaquinaria()
        {
            Random aleatorio = new Random();
            int probabilidad = aleatorio.Next(0, 10);

            if (probabilidad <= 7)
                Averiada = false;
            else
                Averiada = true;
        }

        public void IdentificarDispobilidadPieza()
        {
            Random aleatorio = new Random();
            int probabilidad = aleatorio.Next(0, 1);

            if (probabilidad == 0)
                PiezaDisponible = false;
            else
                PiezaDisponible = true;
        }
    }
}
