using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models
{
     class MServidor
    {
        //PLATILLO+++++++++++++++++++++++++++++++++++++++++++
        public int Id { get; set; } //0
        public int Pedido { get; set; }//1
        public string NombrePlatillo { get; set; }//2
        public string CaracteristicasPlat { get; set; }//3
        public double PrecioPlat { get; set; }//4
        public double CantidadPlat { get; set; }//5
        
        //BEBIDA+++++++++++++++++++++++++++++++++++++++++++
        public string NombreBebida { get; set; }//6
        public string CaracteristicasBebi { get; set; }//7
        public double PrecioBebi { get; set; }//8
        public double CantidadBebi { get; set; }//9
    }
}
