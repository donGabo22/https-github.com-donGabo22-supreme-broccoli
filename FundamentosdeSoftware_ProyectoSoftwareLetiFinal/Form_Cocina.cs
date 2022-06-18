using FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Form_Cocina : Form
    {

        Queue<Pedidos> ordenes;
        private int min, seg;
        bool reiniciar;
        
        public Form_Cocina()
        {
            InitializeComponent();
            min = 0;seg = 10;
        }

        private void btnTomarPedido_Click(object sender, EventArgs e)
        {
            if (reiniciar == true)
            {
                reiniciarTiempo();
            }
            timer1.Enabled = true;
           
        }

        private void Form_Cocina_Load(object sender, EventArgs e)
        {
            mostrartabla();//Mostrar la tabla cuando cargue el Form 
            dgvCocinaPedidos.Left = 500;

            DialogResult result = MessageBox.Show("<<<tienes una nueva orden>>> ¿Aceptar Orden?", "QUERRY SOFTWARE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        }


        private void mostrartabla()
        {
             using (var context = new ApplicationDbContext())
             {
                 var meem = context.MServidor.ToList();

                 dgvCocinaPedidos.DataSource = meem;
             }
             ordenes = new Queue<Pedidos>();
            Pedidos pe= new Pedidos();


        }//FIN MOSTRAR TABLA

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            mostrartabla();
            if (MessageBox.Show("quieres llamar al mesero?", "salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("mesero se lleva la orden");
            }
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seg == 0)
            {
                min--;
                seg = 60;
            }
            seg--;
            lbTemporizador.Text = min + ":" + seg;
            if (min<0) {
                timer1.Enabled = false;
                MessageBox.Show("SE AGOTÓ EL TIEMPO");
                min = 0;seg = 0;
                lbTemporizador.Text = min + ":" + seg;
                reiniciar = true;

            }
           
        }

        private void Form_Cocina_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void actualizarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrartabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_InicializandoInstalación f = new Form_InicializandoInstalación();
            f.Show();
        }

        public void reiniciarTiempo() {
            min = 1;seg = 30;
        }
    }
}
