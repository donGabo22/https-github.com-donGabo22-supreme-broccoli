using FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class FormCaja : Form
    {
        public int Id = 0;

        public FormCaja()
        {
            InitializeComponent();
            btnFinalizarVenta.Enabled = false;
            btnCalcularTotal.Enabled = false;
            btnRegistrarVenta.Enabled = false;
            button1.Enabled = false;
            txtEfectivo.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarPedido();
        }
        private void DgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AgarrarDatosPedido();
        }
        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            calcularTtotalPLATILLO();
            calcularTtotalBebida();
            calcularTotalTotal();
            btnCalcularTotal.Enabled = false;
            btnFinalizarVenta.Enabled = false;
            txtEfectivo.Enabled = true;
        }
        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            btnFinalizarVenta.Enabled = true;
            
            
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            FinalizarVentaF();
            btnFinalizarVenta.Enabled = false;
            btnRegistrarVenta.Enabled = true;
            txtEfectivo.Enabled = false;
        }
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (double.Parse(lblTotalApagar.Text)>double.Parse(txtEfectivo.Text))
            {
                MessageBox.Show("Revise el efectivo, no alcanza a pagar la deuda");
                btnRegistrarVenta.Enabled=false;    
            }
            else
            {
                AñadirVenta();
                   TodasVentas();
                MessageBox.Show("Gracias por su preferencia, su compra ya quedo registrada, enseguida le llegara su tiket");
                btnRegistrarVenta.Enabled = false;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Exterminar();
        }
        //METODOS**************************************************************************

        private void BuscarPedido()
        {

            using (var context = new ApplicationDbContext())
            {
                var pedido = context.MServidor.Where(x => x.Pedido.ToString().Contains(txtbuscarPedido.Text)).ToList();
                DgvPedido.DataSource = pedido;
            }



        }


        private void AgarrarDatosPedido()
        {

            Id = Convert.ToInt32(DgvPedido.CurrentRow.Cells[0].Value.ToString());
            lblPedido.Text = DgvPedido.CurrentRow.Cells[1].Value.ToString();
            lblNombrePlat.Text = DgvPedido.CurrentRow.Cells[2].Value.ToString();
            lblCaracteristicasPlat.Text = DgvPedido.CurrentRow.Cells[3].Value.ToString();
            lblPrecioPlat.Text = DgvPedido.CurrentRow.Cells[4].Value.ToString();
            lblCantidadPlat.Text = DgvPedido.CurrentRow.Cells[5].Value.ToString();


            lblNombreBebi.Text = DgvPedido.CurrentRow.Cells[6].Value.ToString();
            lblCaracteristicasBebi.Text = DgvPedido.CurrentRow.Cells[7].Value.ToString();
            lblPrecioBebida.Text = DgvPedido.CurrentRow.Cells[8].Value.ToString();
            lblCantidadBebi.Text = DgvPedido.CurrentRow.Cells[9].Value.ToString();
            
            btnRegistrarVenta.Enabled = false;




            btnCalcularTotal.Enabled = true;
            button1.Enabled = true;
        }
        private void calcularTtotalPLATILLO()
        {
            int CantidadP = int.Parse(lblCantidadPlat.Text);
            double precioP = double.Parse(lblPrecioPlat.Text);
            double totalP = CantidadP * precioP;
            lblTotalPlat.Text = totalP.ToString();
        }
        private void calcularTtotalBebida()
        {
            int CantidadB = int.Parse(lblCantidadBebi.Text);
            double precioB = double.Parse(lblPrecioBebida.Text);
            double totalB = CantidadB * precioB;
            lblTotalBebi.Text = totalB.ToString();
        }
        private void calcularTotalTotal()
        {
            double TOTALP = double.Parse(lblTotalPlat.Text);
            double TOTALB = double.Parse(lblTotalBebi.Text);
            double TotalTotal = TOTALP + TOTALB;
            lblTotalApagar.Text=TotalTotal.ToString();
        }
        private void FinalizarVentaF()
        {
            double Efec = double.Parse(txtEfectivo.Text);
            double total = double.Parse(lblTotalApagar.Text);
            double cambio = Efec - total;
            lblDevolucion.Text = cambio.ToString();
        }
        private void AñadirVenta()
        {
            using (var context = new ApplicationDbContext())
            {
                var Registro2 = new Registradora();
                Registro2.Pedido = (int.Parse(lblPedido.Text));
                //PLATILLO***********************************************************
                Registro2.Platillo = lblNombrePlat.Text;
                Registro2.CaracteristicasP = lblCaracteristicasPlat.Text;
                Registro2.PreciOP = (int)Double.Parse(lblPrecioPlat.Text);
                Registro2.CantidadP = (int)Double.Parse(lblCantidadPlat.Text);
                Registro2.TotalP = (int)Double.Parse(lblTotalPlat.Text);
                //BEBIDA++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                Registro2.Bebida = lblNombreBebi.Text;
                Registro2.CaracteristicasB = lblCaracteristicasBebi.Text;
                Registro2.PrecioB = (int)Double.Parse(lblPrecioBebida.Text);
                Registro2.CantidadB = (int)Double.Parse(lblCantidadBebi.Text);
                Registro2.TotalB = (int)Double.Parse(lblTotalBebi.Text);
                //CUENTAS****************************************************************
                Registro2.TotalF = (int)Double.Parse(lblTotalApagar.Text);
                Registro2.Efectivo = (int)Double.Parse(txtEfectivo.Text);
                Registro2.Devolucion = (int)Double.Parse(lblDevolucion.Text);
                Registro2.Fecha_Venta = dtpFechaVenta.Value.Date;
                //***********************************************************
                context.Registradora.Add(Registro2);
                //************************************************************+
                context.SaveChanges();
            }

        }
        private void TodasVentas()
        {
            using (var context = new ApplicationDbContext())
            {
                var registradora1 = context.Registradora.ToList();
                dgvcaja.DataSource = registradora1;
            }
        }
        private void Exterminar()
        {
            lblPedido.Text = "";
            lblNombrePlat.Text = "";
            lblCaracteristicasPlat.Text = "";
            lblPrecioPlat.Text = "";
            lblCantidadPlat.Text = "";
            lblTotalPlat.Text = "";

            lblNombreBebi.Text = "";
            lblCaracteristicasBebi.Text = "";
            lblPrecioBebida.Text = "";
            lblCantidadBebi.Text = "";
            lblTotalBebi.Text = "";

            lblTotalApagar.Text = "";
            txtEfectivo.Text = "";
            lblDevolucion.Text = "";
            btnCalcularTotal.Enabled = false;
            btnFinalizarVenta.Enabled = false;
            btnRegistrarVenta.Enabled = false;
            button1.Enabled = false;
            txtEfectivo.Enabled = false;    
            
        }

        private void FormCaja_Load(object sender, EventArgs e)
        {

        }

        private void dgvcaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
