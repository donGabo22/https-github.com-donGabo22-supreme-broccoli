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
        public Graphics lona;
        public SolidBrush brocha;
        public Pen pluma;
        public Random num;
        public Form_Dashboard()
        {
            InitializeComponent();
        }
        public Form_Dashboard(Form_Login.datos info)
        {
            InitializeComponent();
            lblusuario.Text="Bienvenido \n " + info.name;

        }


        private void horaYfecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("H:mm:ss: tt");
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            label1.Left = this.Width - label1.Left + 50;

            ////Pastel1.Left = 1600;
            ////pastel2.Left = 1600;
            ////pastel3.Left = 1600;
            ////pastel4.Left = 1600;
            ////pastel5.Left = 1600;
            ////pastel6.Left = 1600;
            ////pastel7.Left = 1600;
            ////pastel8.Left = 1600;













            lblHora.Left = this.Width - lblHora.Left;
            lblFecha.Left = this.Width - lblFecha.Left -6;
            lona = CreateGraphics();
            pluma = new Pen(Color.Black);
            num = new Random();
            brocha = new SolidBrush(Color.Red);
            int[] numeros = new int[8];
            float x = 0;
            float[] porcentaje = new float[8];
            float[] grados = new float[8];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = num.Next(100);
                x = x + numeros[i];
            }//fin del for con i
            float grados_acum = 0;
            for (int j = 0; j < porcentaje.Length; j++)
            {
                porcentaje[j] = (numeros[j] / x) * 100;
                grados[j] = (numeros[j] / x) * 360;
                brocha.Color = Color.FromArgb(num.Next(255), num.Next(255), num.Next(255));
                lona.FillPie(brocha, this.Width-550, 200,      450, 450, grados_acum, grados[j]);
                grados_acum = grados_acum + grados[j];
                if (j == 0) { Pastel1.ForeColor = brocha.Color; }
                if (j == 1) { pastel2.ForeColor = brocha.Color; }
                if (j == 2) { pastel3.ForeColor = brocha.Color; }
                if (j == 3) { pastel4.ForeColor = brocha.Color; }
                if (j == 4) { pastel5.ForeColor = brocha.Color; }
                if (j == 5) { pastel6.ForeColor = brocha.Color; }
                if (j == 6) { pastel7.ForeColor = brocha.Color; }
                if (j == 7) { pastel8.ForeColor = brocha.Color; }




            }//fin del for con j

            //porcentajes y grados en el label
            Pastel1.Text = "Platillo No:   " + Math.Round(porcentaje[0]);
            pastel2.Text = "Platillo No:   " + Math.Round(porcentaje[1]);
            pastel3.Text = "Platillo No:   " + Math.Round(porcentaje[2]);
            pastel4.Text = "Platillo No:   " + Math.Round(porcentaje[3]);
            pastel5.Text = "Platillo No:   " + Math.Round(porcentaje[4]);
            pastel6.Text = "Platillo No    " + Math.Round(porcentaje[5]);
            pastel7.Text = "Platillo No:   " + Math.Round(porcentaje[6]);
            pastel8.Text = "Platillo No:   " + Math.Round(porcentaje[7]);  

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

        private void btnRol_Click(object sender, EventArgs e)
        {
            FrmEmpleados FC = new FrmEmpleados();
            
            FC.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FormMenu frmM = new FormMenu();
            this.Hide();
            frmM.Show();
        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea salir?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form_Login frmLogin = new Form_Login();
                frmLogin.Show();
            }
        }
    }



}
