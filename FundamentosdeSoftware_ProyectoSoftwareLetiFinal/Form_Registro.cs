using FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Form_Registro : Form
    {
        public Form_Registro()
        {
            InitializeComponent();
        }

        private void btnFinalizarRegistro_Click(object sender, EventArgs e)
        {
            label8.Visible =false;

            bool bandera = false;
            for (int i = 0; i < txbEmail.TextLength; i++)
            {
                if (txbEmail.Text.Contains('@')) {
                    bandera = true;

                }
            }

            if (bandera==true)
            {
                lblEmail.Visible = false;
                pberror.Visible = false;
                btnFinalizarRegistro.Visible = false;//?
                progreso.Enabled = true;
                pbrTrabajo.Value = 0;

                using (var context = new ApplicationDbContext())
                {
                    //paso 1 crear el objeto 
                    var registro1 = new Registros();
                    registro1.Nombre = txbNombre.Text;
                    registro1.Apellido = txbApellido.Text;
                    registro1.Email = txbEmail.Text;
                    registro1.Contraseña = txbContraseña.Text;

                    context.Registros.Add(registro1);



                    context.SaveChanges();


                }
                using (var context = new ApplicationDbContext())
                {
                    var inv = context.Registros.ToList();
                    //dgvinventario.DataSource = inv;
                }
            }
            if (bandera==false)
            {
          
                MessageBox.Show("correo invalido","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            {
               
            }
        
        }

        private void txbConfirmar_TextChanged(object sender, EventArgs e)
        {
            txbConfirmar.Text = txbConfirmar.Text;
            if (txbConfirmar.Text == txbContraseña.Text)
            {
                btnFinalizarRegistro.Enabled = true;
                label8.Text = ".";
                pberror.Visible = false;
                pbcorrecto.Visible = true;

                label8.Text = "la contraseña " +
                   "\n coincide";

            }
            if (txbConfirmar.Text != txbContraseña.Text)
            {
                btnFinalizarRegistro.Enabled = false;
                label8.Text = "la contraseña " +
                    "\n no coincide";
                pbcorrecto.Visible = false;
                pberror.Visible = true;
            }
        }

        private void Form_Registro_Load(object sender, EventArgs e)
        {
            pbrTrabajo.Value = 0;

        }



















        private void progreso_Tick(object sender, EventArgs e)
        {
            pbrTrabajo.Value++;
            if (pbrTrabajo.Value == 100)
            {
                progreso.Enabled = false;
                progreso.Stop();
                this.Close();

                Form_Login frml = new Form_Login();
                frml.Show();
                //   Form_HoraYFecha frmhorayfecha = new Form_HoraYFecha();
                //  frmhorayfecha.Show();
            }
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.facebook.com/profile.php?id=100076262024162") { UseShellExecute = true });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://web.whatsapp.com/") { UseShellExecute = true });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.instagram.com") { UseShellExecute = true });
        }

      
    }
}
