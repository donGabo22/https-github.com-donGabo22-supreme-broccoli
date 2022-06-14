using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

       public struct datos
        {
            public string name;


        }


        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Nombre,Contraseña FROM Registros WHERE Nombre='" + txbUsuario.Text + "' AND Contraseña='" + txbContraseña.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {

                            datos info;
                            info.name = txbUsuario.Text;
                            Form_Dashboard obj = new Form_Dashboard(info);
                            this.Hide();
                            obj.Show();

                            //Form_Dashboard frmd = new Form_Dashboard();
                            //this.Hide();
                            //frmd.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña invalido");
                        }

                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }



   



        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form_Registro frmr = new Form_Registro();
            frmr.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (txbUsuario.Text == "Admin" && txbContraseña.Text == "pass")
            //{
            //    Form_Dashboard frmd = new Form_Dashboard();
            //    frmd.ShowDialog();
            //}


            logins();






        }
        public static bool Login(string user, string pass) =>
            user == "fulanito".ToLower() && pass == "12345" ? true : false;

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://web.whatsapp.com/") { UseShellExecute = true });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.facebook.com/profile.php?id=100076262024162") { UseShellExecute = true });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.instagram.com") { UseShellExecute = true });



        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_InicializandoInstalación frml = new Form_InicializandoInstalación();
            frml.Show();
        }
    }
}