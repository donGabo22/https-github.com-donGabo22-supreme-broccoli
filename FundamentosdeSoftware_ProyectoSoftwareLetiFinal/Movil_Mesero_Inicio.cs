using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Movil_Mesero_Inicio : Form
    {


        public Movil_Mesero_Inicio()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormServidos orden = new FormServidos();
            orden.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Movil_Mesero_Login frmi =  new Movil_Mesero_Login();
            frmi.Show();

        }
    }
}
