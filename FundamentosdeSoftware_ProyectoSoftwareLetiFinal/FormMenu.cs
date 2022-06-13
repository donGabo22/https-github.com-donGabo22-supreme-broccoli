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
    public partial class FormMenu : Form
    {
        int id;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
          

            if (txtNomb.Text != "" && txtCarac.Text != "" && txtPrecio.Text != "")// Condicion para que los campos no queden vacios 
            {
                Food();
            }
            else
            {
                MessageBox.Show("Favor de llenar todos los campos :)");// En caso de error se dezpliega el mensage
            }


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
                        platill.Platillo = txtNomb.Text.ToLower();
                        platill.Caracter = txtCarac.Text.ToLower();
                        platill.Categoria = rbtnPlatt.Checked ? "Platillos" : "Bebidas";
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
                platill.Platillo = txtNomb.Text.ToLower();
                platill.Caracter = txtCarac.Text.ToLower();

                platill.Categoria = rbtnPlatt.Checked ? "Platillos" : "Bebidas";
                platill.precio = double.Parse(txtPrecio.Text.ToLower());

                context.Menuu.Add(platill);

                context.SaveChanges();

            }
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvMenu.CurrentRow.Cells[0].Value.ToString().ToLower());

            //if (rbtnPlatt.Checked== true)
            //{
            //    rbtnPlatt.Text = dgvMenu.CurrentRow.Cells[1].Value.ToString();
            //}

            //if (rbtnBebid.Checked==true)
            //{
            //    rbtnBebid.Text = dgvMenu.CurrentRow.Cells[1].Value.ToString();
            //}

            //if (rbtnPost.Checked==true)
            //{
            //    rbtnPost.Text = dgvMenu.CurrentRow.Cells[1].Value.ToString();
            //}




            //else if (rbtnBebid.Checked = true)
            //{
            //    rbtnBebid.Checked = true;
            //}
            //else if(rbtnPost.Checked = true)
            //{8
            //    rbtnPost.Checked = true;
            //}

            txtNomb.Text = dgvMenu.CurrentRow.Cells[2].Value.ToString().ToLower();
            txtCarac.Text = dgvMenu.CurrentRow.Cells[3].Value.ToString().ToLower();
            txtPrecio.Text = dgvMenu.CurrentRow.Cells[4].Value.ToString().ToLower();
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

        private void FormMenu_Load(object sender, EventArgs e)
        {
            mostrartabla();//Mostrar la tabla cuando cargue el Form 
            pictureBox1.Left = this.Width - pictureBox1.Width - 100;
        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Dashboard frmd = new Form_Dashboard();
            frmd.Show();
        }
        private void mostrartabla()
        {
            using (var context = new ApplicationDbContext())
            {
                var Prov = context.Menuu.ToList();
                dgvMenu.DataSource = Prov;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNomb.Clear();
            txtCarac.Clear();
            txtPrecio.Clear();
            rbtnBebid.Equals(false);
            rbtnPlatt.Equals(false);

        }






        public void Food()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Platillo FROM Menuu WHERE Platillo='" + txtNomb.Text.ToLower()+  "'" , conexion))  

                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            MessageBox.Show("no puedes poner el mismo platillo 2 veces");

                        }
                        else
                        {
                            AggPlat();// Mando llamar al metodo para registrar
                            BuscPlatillo();//Actualizar la tabla con el nuevo registro 
                        }

                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }




        }
    }
}
