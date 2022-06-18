using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Form_InicializandoInstalación : Form
    {
        public bool banderaAdmin  = false;
        public bool banderaMesero = false;
        public bool banderaCocina = false;
        public bool banderaCajero = false;

        public Form_InicializandoInstalación()
        {
            InitializeComponent();
        }

        private void progreso_Tick(object sender, EventArgs e)
        {
            if (pbProgreso.Value < 100)
                pbProgreso.Value++;

            if (pbProgreso.Value == 25)
            {
                //  lblComentario.Visible = false;
                lblComentario.Text = "Comprobando si hay actualizaciones... " +
                    "\n no apague ni desconectes el dispositivo mientras el software está en ejecución...[2/4]";
                lblComentario.TextAlign = ContentAlignment.MiddleCenter;
            }

            if (pbProgreso.Value == 50)
            {
                lblComentario.Text = "Verificando la versión mas reciente..." +
                    "\n no apague ni desconectes el dispositivo mientras el software está en ejecución...[3 / 4]";
                lblComentario.TextAlign = ContentAlignment.MiddleCenter;
            }

            if (pbProgreso.Value == 75)
            {
                lblComentario.Text = "Hay algo bueno para ti por llegar ...[4/4]";
                lblComentario.TextAlign = ContentAlignment.MiddleCenter;
            }

            if (pbProgreso.Value == 100)
            {
                progreso.Enabled = false;
                progreso.Stop();
                this.Hide();

                if (banderaAdmin == true)
                {
                    this.Hide();
                    Form_Login frmL = new Form_Login();
                    frmL.Show();
                }

                if (banderaMesero == true)
                {
                    this.Hide();
                    Movil_Mesero_Login mr = new Movil_Mesero_Login();
                    mr.Show();

                }

                if (banderaCocina== true)
                {
                    Form_LoginCocina lgc = new Form_LoginCocina();
                    this.Hide();
                    lgc.Show();
                }

                if (banderaCajero==true)
                {
                    Form_LoginCajero frmc = new Form_LoginCajero();
                    this.Hide();
                    frmc.Show();

                }


          
            }
            }

            private void Form_InicializandoInstalación_Load(object sender, EventArgs e)
        {
            pbProgreso.Value = 0;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            banderaAdmin = true;
            progreso.Enabled = true;
            lblComentario.Visible = true;
            

        }

        private void BtnMesero_Click(object sender, EventArgs e)
        {
            banderaMesero = true;
            progreso.Enabled = true;
            lblComentario.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            banderaCocina = true;
            progreso.Enabled = true;
            lblComentario.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            banderaCajero = true;
            progreso.Enabled = true;
            lblComentario.Visible = true;
        }
    }
}
