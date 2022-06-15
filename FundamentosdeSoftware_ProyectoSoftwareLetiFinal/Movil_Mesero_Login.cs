using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Form_Login;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Movil_Mesero_Login : Form
    {
        public Movil_Mesero_Login()
        {
            InitializeComponent();
        }

        //public struct Datos
        //{
        //    public string Nombre;
        //}

        
//private void btnLogin_Click(object sender, EventArgs e)
//        {
            
//            Datos info;
//            info.Nombre = txbUsuario.ToString(); 
            
//            Movil_Mesero_Inicio env=new Movil_Mesero_Inicio(info);
//            env.ShowDialog(); 
//        }
        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Nombre FROM Empleados WHERE Nombre='" + txbUsuario.Text+ "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {

                            if (TxbPass.Text == "2345")
                            {
                                Movil_Mesero_Inicio or = new Movil_Mesero_Inicio();
                                this.Hide();
                                or.Show();
                            }
                            else
                            {
                                MessageBox.Show("Contraseña inválida");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario  invalido");
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            logins();
        }

        
    }
}
