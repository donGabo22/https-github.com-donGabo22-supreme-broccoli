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
    public partial class Form_MenuNuevoK : Form
    {
        public int Id = 0;

        public Form_MenuNuevoK()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text!=""&&txtCaracteristicas.Text!="")
            {
                AgregarPlatillo();
                TodosPlatos();
                
            }
            else
            {
                MessageBox.Show("Hay campos faltantes por llenar");
                btnRegistrar.Enabled = false;
            }
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDatos();
            TodosPlatos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Aniquilar();
            TodosPlatos();
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAlimento();
        }
        //Metodos****************************************************************************++

        private void AgregarPlatillo()
        {
            using (var context = new ApplicationDbContext())
            {
                var Plato = new RegistroComida();
                Plato.NombrePlat = txtPlatillo.Text;
                Plato.NombreBebi = txtBebida.Text;
                Plato.Caracteristicas = txtCaracteristicas.Text;
                Plato.precioCoB = Double.Parse(txtPrecio.Text);

                //***********************************************************
                context.RegistroComida.Add(Plato);
                //************************************************************+
                context.SaveChanges();
            }
        }
        private void TodosPlatos()
        {
            using (var context = new ApplicationDbContext())
            {
                var plato= context.RegistroComida.ToList();
                dgvMenu.DataSource = plato;
            }
        }
        private void ModificarDatos()
        {
            using (var context = new ApplicationDbContext())
            {
                if (Id != 0)
                {
                    var plato = context.RegistroComida.First(x => x.Id == Id);
                    if (plato != null)
                    {
                        plato.NombrePlat = txtPlatillo.Text;
                        plato.NombreBebi = txtBebida.Text;
                        plato.Caracteristicas= txtCaracteristicas.Text;
                        plato.precioCoB = Double.Parse(txtPrecio.Text);
                        context.SaveChanges();
                    }
                }
            }
        }
        private void Aniquilar()
        {
            using (var context = new ApplicationDbContext())
            {
                if (Id != 0)
                {
                    var plato = context.RegistroComida.First(x => x.Id == Id);
                    if (plato != null)
                    {
                        context.Remove(plato);
                        context.SaveChanges();
                        
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBebida.Text = "";
            txtCaracteristicas.Text = "";
            txtPlatillo.Text = "";
            txtBuscar.Text = "";
            txtPrecio.Text = "";
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = true;
            txtBebida.Enabled = true;
            txtPlatillo.Enabled = true;
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value.ToString());
            txtPlatillo.Text = dgvMenu.CurrentRow.Cells[1].Value.ToString();
            txtBebida.Text = dgvMenu.CurrentRow.Cells[2].Value.ToString();
            txtCaracteristicas.Text = dgvMenu.CurrentRow.Cells[3].Value.ToString();
            txtPrecio.Text = dgvMenu.CurrentRow.Cells[4].Value.ToString();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRegistrar.Enabled = false;
        }

        private void txtCaracteristicas_TextChanged(object sender, EventArgs e)
        {
            if (txtCaracteristicas.Text!="")
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void txtPlatillo_TextChanged(object sender, EventArgs e)
        {
            if (txtPlatillo.Text!="")
            {
                txtBebida.Enabled = false;
            }
        }

        private void txtBebida_TextChanged(object sender, EventArgs e)
        {
            if (txtBebida.Text!="")
            {
                txtPlatillo.Enabled = false;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text!="")
            {
                btnRegistrar.Enabled = true;
            }
        }
        private void BuscarAlimento()
        {
            using (var context = new ApplicationDbContext())
            {
                var plato = context.RegistroComida.Where(x => x.Caracteristicas.Contains(txtBuscar.Text)).ToList();
                dgvMenu.DataSource = plato;
            }
        }

        
    }
}
