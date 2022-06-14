using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models
{
    class Registradora
    {
        //PLATILLO+++++++++++++++++++++++++++++++++++++++++++
        public int Id { get; set; }
        public int Pedido { get; set; }
        public string Platillo { get; set; }
        public string CaracteristicasP { get; set; }
        public double PreciOP { get; set; }
        public double CantidadP { get; set; }
        public double TotalP { get; set; }
        //BEBIDA+++++++++++++++++++++++++++++++++++++++++++
        public string Bebida { get; set; }
        public string CaracteristicasB { get; set; }
        public double PrecioB { get; set; }
        public double CantidadB { get; set; }
        public double TotalB { get; set; }
        //CUENTA+++++++++++++++++++++++++++++++++++++++++++
        public double TotalF { get; set; }
        public double Efectivo { get; set; }
        public double Devolucion { get; set; }
        public DateTime Fecha_Venta { get; set; }
    }
}
