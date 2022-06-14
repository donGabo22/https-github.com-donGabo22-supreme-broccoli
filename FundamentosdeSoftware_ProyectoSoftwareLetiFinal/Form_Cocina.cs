using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Form_Cocina : Form
    {
        private int  min, seg;
        
        public Form_Cocina()
        {
            InitializeComponent();
            min = 0;seg = 10;
        }

        private void btnTomarPedido_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form_Cocina_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seg == 0)
            {
                min--;
                seg = 60;
            }
            seg--;
            if (min == 0 && seg == 0)
            {
                timer1.Enabled = false;
                min = 0;seg = 0;
                lbTemporizador.Text = "<<<< SE AGOTÓ EL TIEMPO >>>>";
            }
            if (min>0) {
                timer1.Enabled = false;
                
            }
            lbTemporizador.Text = min + ":" + seg;
        }

        private void Form_Cocina_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
