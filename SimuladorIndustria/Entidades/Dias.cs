namespace SimuladorIndustria
{
    public class Dias
    {
        public int Numero { get; set; } = 0;
        public double CantidadProducida { get; set; } = 0;
        public double CantidadProducidaALaFecha { get; set; } = 0;

        public Dias()
        {
            Numero = 0;
            CantidadProducida = 0;
            CantidadProducidaALaFecha = 0;
        }
    }
}
