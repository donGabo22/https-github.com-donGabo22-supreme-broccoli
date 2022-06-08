using FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class FormMenu : Form
    {
        int id;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            AggPlat();
            TodPlatillos();

            txtNomb.Clear();
            txtCarac.Clear();
            txtPrecio.Clear();
            rbtnBebid.Equals(false);
            rbtnPlatt.Equals(false);
            rbtnPost.Equals(false);

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {

                    var platill = context.Menuu.First(x => x.Id == id);
                    if (platill != null)
                    {

                        //var platill = new Menuu();
                        platill.Platillo = txtNomb.Text;
                        platill.Caracter = txtCarac.Text;
                        platill.Categoria = rbtnPlatt.Checked ? "Platillos" : "Bebidas" + "Postres";
                        platill.precio = double.Parse(txtPrecio.Text);

                        context.SaveChanges();

                      TodPlatillos();
                    }
                }
            }

        }

        private void TodPlatillos()
        {
            using (var context = new ApplicationDbContext())
            {
                var platillos = context.Menuu.ToList();
               dgvMenu.DataSource = platillos;
            }
        }

        private void btnElim_Click(object sender, EventArgs e)
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

                        TodPlatillos();
                    }
                }

            }
        }


        private void AggPlat()
        {
            using (var context = new ApplicationDbContext())
            {

                var platill = new Menuu();
                platill.Platillo = txtNomb.Text;
                platill.Caracter = txtCarac.Text;
                platill.Categoria = rbtnPlatt.Checked ? "Platillos" : "Bebidas" + "Postres";
                platill.precio = double.Parse(txtPrecio.Text);

                context.Menuu.Add(platill);

                context.SaveChanges();

            }
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value.ToString());
            if (dgvMenu.CurrentRow.Cells[1].Value.ToString() == "Platillos")
            {
                rbtnPlatt.Checked = true;
            }
            else if (rbtnBebid.Checked = true)
            {
                rbtnBebid.Checked = true;
            }
            else if(rbtnPost.Checked = true)
            {
                rbtnPost.Checked = true;
            }
           
            txtNomb.Text = dgvMenu.CurrentRow.Cells[2].Value.ToString();
            txtCarac.Text = dgvMenu.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Text = dgvMenu.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscPlatillo();
        }

        private void BuscPlatillo()
        {

            using (var context = new ApplicationDbContext())
            {
                var platill = context.Menuu.Where(x => x.Platillo.ToUpper().Contains(txtBuscar.Text.ToUpper())).ToList();
                dgvMenu.DataSource = platill;
            }

        }

        private void button1_Click(object sender, EventArgs e) //boton salir
        {
            this.Close();
        }
    }
}
