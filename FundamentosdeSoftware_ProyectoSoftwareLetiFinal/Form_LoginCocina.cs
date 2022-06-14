using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void btnIniciarCocina_Click(object sender, EventArgs e)
        {

            Form_Cocina coc = new Form_Cocina();
            this.Hide();
            coc.Show();
            
        }
    }
}
