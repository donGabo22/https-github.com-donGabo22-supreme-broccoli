﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Movil_Mesero_Menu : Form
    {
        public Movil_Mesero_Menu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movil_Mesero_Inicio mr = new Movil_Mesero_Inicio();
            mr.Show();
        }
    }
}
