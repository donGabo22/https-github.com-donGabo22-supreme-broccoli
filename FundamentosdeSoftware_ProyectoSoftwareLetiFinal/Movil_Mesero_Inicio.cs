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
            Movil_MeserOrden orden = new Movil_MeserOrden();
            orden.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
