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
    public partial class Movil_Mesero_Orden2 : Form
    {
        int id;
        public Movil_Mesero_Orden2()
        {
            InitializeComponent();
        }
        private void Movil_Mesero_Orden2_Load(object sender, EventArgs e)
        {
            mostrartabla();//Mostrar la tabla cuando cargue el Form 



            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                SqlCommand comando = new SqlCommand("SELECT Categoria,Platillo,precio from Menuu where Categoria= 'Bebidas' ", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cmbxNomPlat.Items.Add(registro["PLatillo"].ToString());

                }
                conexion.Close();
            }











        }
        private void pbAgregar_Click(object sender, EventArgs e)
        {
            AgregarPedido();// Mando llamar al metodo para registrar
        }
        private void mostrartabla()
        {
            using (var context = new ApplicationDbContext())
            {
                var meem = context.MeseroOrden.ToList();
                dgvOrdenes.DataSource = meem;
            }

        }

   
        private void AgregarPedido()
        {
            using (var context = new ApplicationDbContext())
            {

                var plato = new MeseroOrden();
                plato.PedidoNum = txbnumPedido.Text.ToLower();

                plato.Platillo = cmbxNomPlat.SelectedItem.ToString();
                plato.precio = double.Parse(tbxPrecio.Text);
                plato.Cantidad = int.Parse(txbCantidad.Text);
                plato.Observacion = txbObserv.Text.ToString();


                context.MeseroOrden.Add(plato);
                context.SaveChanges();

            }
        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvOrdenes.CurrentRow.Cells[0].Value.ToString().ToLower());

            txbnumPedido.Text = dgvOrdenes.CurrentRow.Cells[1].Value.ToString().ToLower();

            cmbxNomPlat.Text = dgvOrdenes.CurrentRow.Cells[2].Value.ToString();//sera text o item??

            tbxPrecio.Text = dgvOrdenes.CurrentRow.Cells[3].Value.ToString().ToLower();

            txbCantidad.Text = dgvOrdenes.CurrentRow.Cells[4].Value.ToString().ToLower();

            txbObserv.Text = dgvOrdenes.CurrentRow.Cells[4].Value.ToString().ToLower();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //mod
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {

                    var plato = context.MeseroOrden.First(x => x.Id == id);
                    if (plato != null)
                    {

                        //var platill = new Menuu();
                        plato.PedidoNum = txbnumPedido.Text.ToLower();
                        plato.Platillo = cmbxNomPlat.SelectedItem.ToString().ToLower();
                        plato.precio = double.Parse(tbxPrecio.Text.ToLower());
                        plato.Observacion = txbObserv.Text;

                        context.SaveChanges();

                        mostrartabla();
                    }
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {

                    var platos = context.Menuu.First(x => x.Id == id);
                    if (platos != null)
                    {
                        context.Remove(platos);
                        context.SaveChanges();

                        AgregarPedido();
                    }
                }

            }
        }
    }

}
