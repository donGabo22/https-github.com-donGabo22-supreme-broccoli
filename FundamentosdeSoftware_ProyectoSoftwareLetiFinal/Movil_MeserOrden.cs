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
    public partial class Movil_MeserOrden : Form

    {
        int id;
        public Movil_MeserOrden()
        {
            InitializeComponent();
        }


        private void Movil_MeserOrden_Load(object sender, EventArgs e)
        {
             try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Platillo,Precio FROM Menuu", conexion))
                        
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            cmbxNomPlat.Items.Add(dr["Platillo"].ToString());
                            //MessageBox.Show("no puedes poner el mismo platillo 2 veces");
                            tbxPrecio.Text = dr["Precio"].ToString();

                        }
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgOrd_Click(object sender, EventArgs e)
        {
            RegistrarOrd();
            Ordenes();
        }

        private void Ordenes()
        {
            using (var context = new ApplicationDbContext())
            {
                var orden = context.MeserOrd.ToList();
                dgvOrdenes.DataSource = dgvOrdenes;
            }
        }

        private void RegistrarOrd()
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {

                    var orden = context.MeserOrd.First(x => x.Id == id);
                    if (orden != null)
                    {
                        orden.PedidoNum = int.Parse(label7.Text + 1);
                        orden.MesaNum = int.Parse(label3.Text + 1);
                        orden.Categoria = rbtnPlatt.Checked ? "Platillos" : "Bebidas";
                        orden.Platillo = cmbxNomPlat.Text;
                        orden.precio = double.Parse(tbxPrecio.Text);
                        orden.Cantidad = int.Parse(txbCantidad.Text.ToLower());
                        orden.Observacion = txbObserv.Text;

                        context.MeserOrd.Add(orden);
                        context.SaveChanges();

                        Ordenes();
                    }
                }


            }
        }

        private void tnModOrd_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {

                    var orden = context.MeserOrd.First(x => x.Id == id);
                    if (orden != null)
                    {
                        orden.PedidoNum = int.Parse(label7.Text+1);
                        orden.MesaNum = int.Parse(label3.Text+1);   
                        orden.Categoria = rbtnPlatt.Checked ? "Platillos" : "Bebidas";
                        orden.Platillo= cmbxNomPlat.Text;   
                        orden.precio = double.Parse(tbxPrecio.Text);
                        orden.Cantidad = int.Parse(txbCantidad.Text.ToLower());
                        orden.Observacion = txbObserv.Text;

                        context.SaveChanges();

                        Ordenes();
                    }
                }


            }

        }

        private void btnElimOrd_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {

                    var orden = context.MeserOrd.First(x => x.Id == id);
                    if (orden != null)
                    {
                        context.Remove(orden);
                        context.SaveChanges();

                        Ordenes();
                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orden Enviada a Cocina");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orden Enviada a Cajer@");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        //private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    id = Convert.ToInt32(dgvOrdenes.CurrentRow.Cells[0].Value.ToString());
        //    if (dgvOrdenes.CurrentRow.Cells[1].Value.ToString() == "Platillo")
        //    {
        //        rbtnPlatt.Checked = true;
        //    }
        //    else
        //    {
        //        rbtnBebid.Checked = true;
        //    }
            
        //}
    }
}


