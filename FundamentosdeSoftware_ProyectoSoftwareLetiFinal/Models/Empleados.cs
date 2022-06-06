using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models
{
     class Empleados
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Rol_Asignado { get; set; }
        public string Salario { get; set; }
        public string Sexo { get; set; }
        public string RFC { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Horario { get; set; }


    }
}
