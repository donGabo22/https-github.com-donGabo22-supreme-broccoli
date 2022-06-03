using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }
        public Form_Dashboard(Form_Login.datos info)
        {
            InitializeComponent();
            lblusuario.Text="Bienvenido " + info.name;

        }


        private void horaYfecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("H:mm:ss: tt");
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            lblHora.Left = this.Width - lblHora.Left;
            lblFecha.Left = this.Width - lblFecha.Left + 10;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Configuracion frmconfiguraion = new Form_Configuracion();
            frmconfiguraion.Show();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }




     









        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //aqui va el codigo para abrir y leer el archivo

                pbFoto.Load(openFileDialog1.FileName);
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;


            }
        }
        public static string something() {
            return "Algo";
        }
        
        
    }



}
