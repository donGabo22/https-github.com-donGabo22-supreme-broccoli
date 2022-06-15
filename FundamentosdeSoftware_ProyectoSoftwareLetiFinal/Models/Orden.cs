using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models
{
    class Orden
    {
        public int Id { get; set; }
        public int NumeroPedido { get; set; }

        public string NombrePlatillo { get; set; }
        public double PrecioPlatillo { get; set; }
        public int CantidadPLatillo { get; set; }
        public string ComentarioPlatillo { get; set; }



        public string NombreBebida { get; set; }
        public double PrecioBebida { get; set; }
        public int CantidadBebida { get; set; }
        public string ComentarioBebida { get; set; }

    }
}
