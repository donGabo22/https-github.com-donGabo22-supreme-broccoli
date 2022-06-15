using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models
{
    internal class MeseroOrden
    {
        public int Id { get; set; }
        public string PedidoNum { get; set; }
        public string Platillo { get; set; }
        public double precio { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
    }
}
