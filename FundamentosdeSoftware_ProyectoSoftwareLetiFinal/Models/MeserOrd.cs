using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models
{
    internal class MeserOrd
    {
        public int Id { get; set; }
        public int PedidoNum { get; set; }
        public int MesaNum { get; set; }
        public string Categoria { get; set; }
        public string Platillo { get; set; }
        //public string Caracter { get; set; }
        public double precio { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
    }
}
