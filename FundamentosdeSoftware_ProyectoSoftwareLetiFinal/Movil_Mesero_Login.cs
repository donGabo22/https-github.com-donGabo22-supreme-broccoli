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
                        using (SqlCommand cmd = new SqlCommand("SELECT Nombre FROM Empleados WHERE Rol_Asignado='Mesero' and Nombre= '" + txbUsuario.Text + "'", conexion))
                        {
                            SqlDataReader dr = cmd.ExecuteReader();

                            if (dr.Read())
                            {

                                if (TxbPass.Text == "12345")
                                {
                                Movil_Mesero_Inicio or = new Movil_Mesero_Inicio();
                                    this.Hide();
                                    or.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txbUsuario.Text = "";
                                    TxbPass.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txbUsuario.Text = "";
                                TxbPass.Text = "";
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
           // FormServidos form=new FormServidos();
           // form.ShowDialog();
            logins();
        }

        private void TxbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            Form_InicializandoInstalación frmi = new Form_InicializandoInstalación();
                frmi.Show();
        }
    }
}
