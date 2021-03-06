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
    public partial class Form_LoginCocina : Form
    {
        public Form_LoginCocina()
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
                    using (SqlCommand cmd = new SqlCommand("SELECT Nombre FROM Empleados WHERE Rol_Asignado='Chef' and Nombre= '"  + textBox1.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {

                            if (textBox2.Text == "12345")
                            {
                                Form_Cocina or = new Form_Cocina();
                                this.Hide();
                                or.Show();
                            }
                            else
                            {
                                MessageBox.Show("Contraseña invalida?", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBox1.Text = "";
                                textBox2.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Correo invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox1.Text = "";
                            textBox2.Text = "";
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
            this.Close();
            Form_InicializandoInstalación frmi = new Form_InicializandoInstalación();
            frmi.Show();
        }
    }
}
