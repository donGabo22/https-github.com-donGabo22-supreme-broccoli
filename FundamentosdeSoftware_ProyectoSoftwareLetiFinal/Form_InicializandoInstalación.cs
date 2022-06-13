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
                Form_Login frmL = new Form_Login();
                frmL.Show();
                //   Form_Registro frmRegistro = new Form_Registro();
                //   frmRegistro.ShowDialog();

                // Form_HoraYFecha frmHoraYFecha = new Form_HoraYFecha();
                // frmHoraYFecha.Show();
                //                Form_Dashboard frm = new Form_Dashboard();
                //              frm.Show();
            }
            }

            private void Form_InicializandoInstalación_Load(object sender, EventArgs e)
        {
            pbProgreso.Value = 0;
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Querry Sotware Sigue en constante desarrollo por lo que algunas funcionalidades pueden verse limitadas, ¿Esta seguro que desea inicializar el modo Administrador? ", "QUERRY SOFTWARE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (result == DialogResult.Yes)
            //{
            //    progreso.Enabled = true;
            //    lblComentario.Visible = true;
            //}
            FormMenu frmm = new FormMenu();
            frmm.Show();

        }

        private void BtnMesero_Click(object sender, EventArgs e)
        {
            Movil_Mesero_Inicio mr = new Movil_Mesero_Inicio();
            mr.Show();
        }
    }
}
