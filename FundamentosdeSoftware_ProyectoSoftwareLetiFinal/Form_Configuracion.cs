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
    public partial class Form_Configuracion : Form
    {
        public Form_Configuracion()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            comboBox3.Visible = true;
            linkLabel1.LinkVisited = true;
            lblNota.Visible = true;
        }

        private void Form_Configuracion_Load(object sender, EventArgs e)
        {
            lblNota.Visible = false;
            panel2.Top = 0;
            panel2.Left = this.Width - panel2.Width - 100;
            comboBox3.Visible = false;
        }

        private void btnInformacionSoftware_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Querry Software ® Proyecto Hecho por: \n " +
             "Gabriel Herández Diaz \n" +
             "Luis David Cazares Morales \n" +
             "Fabiola Rodriguez Salvador \n" +
             "Kevin Fared Velazquez Vargas \n" +
             "Maestra: Leticia Lizárraga Velarde \n" +
             "Materia: Ingenieria de Software ", "Información", MessageBoxButtons.OK);
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Sugerencias: con tu opinión podemos mejorar tu experiencia Cel: 6485051485 \n" +
               "Numero en caso de reportar problemas o asistencia con el software las 24 HRS: 6391725495" +
               " ", "Administrador", MessageBoxButtons.OK);


        }

        private void pbCerrarSeccion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea salir?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form_Login frmLogin = new Form_Login();
                frmLogin.Show();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNota.Visible = false;
        }

        private void rbDesactivado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDesactivado.Checked == true)
            {
                txbImpuesto.Text = ".";
                txbImpuesto.Enabled = false;
            }
        }

        private void rbActivado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActivado.Checked == true)
            {
                txbImpuesto.Enabled = true;


            }
        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Dashboard frm = new Form_Dashboard();
            frm.Show();
        }
    }
}
