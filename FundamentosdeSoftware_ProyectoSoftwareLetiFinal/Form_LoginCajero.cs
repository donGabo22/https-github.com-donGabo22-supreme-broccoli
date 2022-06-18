using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Form_LoginCajero : Form
    {
        public Form_LoginCajero()
        {
            InitializeComponent();
        }


        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Nombre FROM Empleados WHERE Rol_Asignado='Cajero' and Nombre= '" + txbUsuario.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {

                            if (TxbPass.Text == "12345")
                            {
                                FormCaja or = new FormCaja();
                                this.Close();

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



















        private void btnIniciarCocina_Click(object sender, EventArgs e)
        {
            logins();
        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_InicializandoInstalación f = new Form_InicializandoInstalación();
            f.Show();
        }
    }
}
