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
    public partial class FormServidos : Form
    {
        int Id = 0;


        public FormServidos()
        {
            InitializeComponent();
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            txtBuscarBebida.Enabled = false;
            txtBuscarPlatillo.Enabled = false;
            txtCantidadBebida.Enabled = false;
            txtCantidadPlatillo.Enabled = false;
        }

        private void txtBuscarPlatillo_TextChanged(object sender, EventArgs e)
        {
            BuscarPlatillo();
        }
        private void txtBuscarBebida_TextChanged(object sender, EventArgs e)
        {
//            BuscarBebida();
        }
        private void DgvPlatillo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AgarrarDatosPlatillo();
        }
        private void DgvBebida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  AgarrarDatosBebida();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if(txtCantidadBebida.Text != "" && txtCantidadPlatillo.Text != "")
            {
                AgregarPedido();
                TodosPedidos();
            }
            else
            {
                btnRegistrar.Enabled = false;
                MessageBox.Show("No se a registrado la cantidad, registre para proceder");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarDatos();
            TodosPedidos();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Aniquilar();
            TodosPedidos();
        }
        private void dgvMesero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AgarrarDatosPedidos();
        }
        //Metodos****************************************************************************************************
        private void AgarrarDatosPedidos()
        {
            Id = Convert.ToInt32(dgvMesero.CurrentRow.Cells[0].Value.ToString());
            txtPedido.Text = dgvMesero.CurrentRow.Cells[1].Value.ToString();
            lblNombrePlatillo.Text = dgvMesero.CurrentRow.Cells[2].Value.ToString();
            lblCaracterPlatillo.Text = dgvMesero.CurrentRow.Cells[3].Value.ToString();
            LblPrecioPlatillo.Text = dgvMesero.CurrentRow.Cells[4].Value.ToString();
            txtCantidadPlatillo.Text = dgvMesero.CurrentRow.Cells[5].Value.ToString();


            lblNombreBebida.Text = dgvMesero.CurrentRow.Cells[6].Value.ToString();
            LblCaracterBbebida.Text = dgvMesero.CurrentRow.Cells[7].Value.ToString();
            LblPrecioBbebida.Text = dgvMesero.CurrentRow.Cells[8].Value.ToString();
            txtCantidadBebida.Text = dgvMesero.CurrentRow.Cells[9].Value.ToString();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnRegistrar.Enabled = false;
        }
        private void ModificarDatos()
        {
            using (var context = new ApplicationDbContext())
            {
                if (Id != 0)
                {
                    var pedido1 = context.MServidor.First(x => x.Id == Id);
                    if (pedido1 != null)
                    {
                        pedido1.Pedido = int.Parse(txtPedido.Text);
                        pedido1.NombrePlatillo = lblNombrePlatillo.Text;
                        pedido1.CaracteristicasPlat = lblCaracterPlatillo.Text;
                        pedido1.PrecioPlat = double.Parse(LblPrecioPlatillo.Text);
                        pedido1.CantidadPlat = double.Parse(txtCantidadPlatillo.Text);

                        //BEBIDA*************************************************************


                        pedido1.NombreBebida = lblNombreBebida.Text;
                        pedido1.CaracteristicasBebi = LblCaracterBbebida.Text;
                        pedido1.PrecioBebi = double.Parse(LblPrecioBbebida.Text);
                        pedido1.CantidadBebi = double.Parse(txtCantidadBebida.Text);

                        context.SaveChanges();

                    }
                }
            }
        }
        private void TodosPedidos()
        {
            using (var context = new ApplicationDbContext())
            {
                var pedido = context.MServidor.ToList();
                dgvMesero.DataSource = pedido;
            }
        }
        private void AgregarPedido()
        {
            using (var context = new ApplicationDbContext())
            {

                var pedido1 = new MServidor();
                pedido1.Pedido = int.Parse(txtPedido.Text);
                pedido1.NombrePlatillo=lblNombrePlatillo.Text;
                pedido1.CaracteristicasPlat=lblCaracterPlatillo.Text;
                pedido1.PrecioPlat=double.Parse(LblPrecioPlatillo.Text);
                pedido1.CantidadPlat=double.Parse(txtCantidadPlatillo.Text);

                //BEBIDA*************************************************************

                
                pedido1.NombreBebida = lblNombreBebida.Text;
                pedido1.CaracteristicasBebi = LblCaracterBbebida.Text;
                pedido1.PrecioBebi = double.Parse(LblPrecioBbebida.Text);
                pedido1.CantidadBebi = double.Parse(txtCantidadBebida.Text);


                //***********************************************************
                context.MServidor.Add(pedido1);
                //************************************************************+
                context.SaveChanges();

            }
        }
        private void BuscarPlatillo()
        {
            using (var context = new ApplicationDbContext())
            {
                var plato1 = context.RegistroComida.Where(x => x.NombrePlat.Contains(txtBuscarPlatillo.Text)).ToList();
                DgvPlatillo.DataSource = plato1;
            }
        }
        private void BuscarBebida()
        {
            using (var context = new ApplicationDbContext())
            {
                var plato1 = context.RegistroComida.Where(x => x.NombreBebi.Contains(txtBuscarBebida.Text)).ToList();
                DgvBebida.DataSource = plato1;
            }

        }
        private void AgarrarDatosPlatillo()
        {
            Id = Convert.ToInt32(DgvPlatillo.CurrentRow.Cells[0].Value.ToString());
            lblNombrePlatillo.Text = DgvPlatillo.CurrentRow.Cells[1].Value.ToString();
            lblCaracterPlatillo.Text = DgvPlatillo.CurrentRow.Cells[3].Value.ToString();
            LblPrecioPlatillo.Text = DgvPlatillo.CurrentRow.Cells[4].Value.ToString();
        }
        private void AgarrarDatosBebida()
        {
            Id = Convert.ToInt32(DgvBebida.CurrentRow.Cells[0].Value.ToString());
            lblNombreBebida.Text = DgvBebida.CurrentRow.Cells[2].Value.ToString();
            LblCaracterBbebida.Text = DgvBebida.CurrentRow.Cells[3].Value.ToString();
            LblPrecioBbebida.Text = DgvBebida.CurrentRow.Cells[4].Value.ToString();
        }

        private void Aniquilar()
        {
            using (var context = new ApplicationDbContext())
            {
                if (Id != 0)
                {
                    var pedido = context.MServidor.First(x => x.Id == Id);
                    if (pedido != null)
                    {
                        context.Remove(pedido);
                        context.SaveChanges();
                       
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPedido.Text = "";
            txtBuscarBebida.Text = "";
            txtBuscarPlatillo.Text = "";
            txtCantidadBebida.Text = "";
            lblNombreBebida.Text = "";
            lblNombrePlatillo.Text = "";
            lblCaracterPlatillo.Text = "";
            LblCaracterBbebida.Text = "";
            LblPrecioBbebida.Text = "";
            LblPrecioPlatillo.Text = "";
            txtCantidadPlatillo.Text = "";
            btnEliminar.Enabled = false;
           
            btnRegistrar.Enabled = false;
            
            
            btnModificar.Enabled = false;
            txtBuscarBebida.Enabled = false;
            txtBuscarPlatillo.Enabled = false;
        }

        private void txtCantidadPlatillo_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidadPlatillo.Text!="")
            {
                btnRegistrar.Enabled = true;
            }
        }

        private void txtCantidadBebida_TextChanged(object sender, EventArgs e)
        {

            //////if (txtCantidadBebida.Text != "")
            //////{
            //////    btnRegistrar.Enabled = true;
            //////}
        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                bool existe = context.MServidor.Any(x => x.Pedido.ToString().Equals(txtPedido.Text));
                //preguntaremos si existe
                if (existe == true)
                {
                    //si no existe se agrega
                    lblvalidez.ForeColor = Color.Red;

                    lblvalidez.Text = "ID Invalido";
                    pbbueno.Visible = false;
                    pbmalo.Visible = true;
               //     MessageBox.Show("El pedido: " + txtPedido.Text + " ya a sido registrado, meta nuevo pedido");
                    btnRegistrar.Enabled = false;

                }
                else
                {
                    lblvalidez.ForeColor= Color.Green;
                    lblvalidez.Text = "ID valido";
                    pbmalo.Visible = false;
                    pbbueno.Visible = true;
                    existe = false;
                    btnRegistrar.Enabled = true;

                }

            }
            if (txtPedido.Text!="")
            {
                txtBuscarBebida.Enabled = true;
                txtBuscarPlatillo.Enabled = true;
                txtCantidadBebida.Enabled=true;
                txtCantidadPlatillo.Enabled=true;
            }
            else
            {
                txtBuscarBebida.Enabled = false;
                txtBuscarPlatillo.Enabled = false;
                txtCantidadPlatillo.Enabled = false;
                txtCantidadBebida.Enabled = false;
            }
        }

        private void FormServidos_Load(object sender, EventArgs e)
        {


            // TodosPedidos();
            //    AgarrarDatosPlatillo();
            //  AgarrarDatosBebida();


        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form_InicializandoInstalación f = new Form_InicializandoInstalación();
            f.Show();
        }

        private void txtBuscarBebida_TextChanged_1(object sender, EventArgs e)
        {
            BuscarBebida();
          
        }

        private void DgvBebida_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
                AgarrarDatosBebida();

        }

        private void txtCantidadBebida_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCantidadBebida.Text != "")
            {
                btnRegistrar.Enabled = true;
            }
        }

        //.....................................................................................................................

        //private void txtBuscarBebida_TextChanged_1(object sender, EventArgs e)
        //{

        //}

        //private void DgvBebida_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void txtCantidadBebida_TextChanged_1(object sender, EventArgs e)
        //{

        //}
    }
}
