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
    public partial class FrmEmpleados : Form
    {

        public int id = 0;
        

        public int Id { get; private set; }
        
        public FrmEmpleados()
        {
            InitializeComponent();
            LblRFC.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtRFC.Text!="" && txtNombre.Text!=""&& txtRFC.Text!=""&& txtApellidoPa.Text!="")
            {
                AgregarEmplados();
                TodosClientes();

            }
            else
            {
                MessageBox.Show("Rellenar los campos faltantes");
                
            }
           
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtRFC.Enabled = false;
            btnRegistrar.Enabled = false;
            ModificarDatos();
            TodosClientes();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Aniquilar();
            TodosClientes();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            LimpiarTexto();
        }
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }
        //Metodoos++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void TodosClientes()
        {
            using (var context = new ApplicationDbContext())
            {
                var Empleados = context.Empleados.ToList();
                dgvEmpleados.DataSource = Empleados;
                context.SaveChanges(); //aqui

            }
        }
        private void AgregarEmplados()
        {
            using (var context = new ApplicationDbContext())
            {

                    var  Empleado1 = new Empleados();
                    Empleado1.Nombre = txtNombre.Text;
                    Empleado1.Apellido_Paterno = txtApellidoPa.Text;
                    Empleado1.Apellido_Materno = txtApellidoMaterno.Text;
                    Empleado1.Rol_Asignado = cbxRol.Text;
                    Empleado1.Salario = cbxSalario.Text;
                    Empleado1.Sexo = rbtFemenino.Checked ? "Femenino" : "Masculino";
                    Empleado1.RFC = txtRFC.Text;
                    Empleado1.Fecha_Nacimiento = dtpFechaNacimiento.Value.Date;
                    Empleado1.Horario = chBxLunes.Checked ? "Lunes-Viernes 9:00pm a 1:00am" : "Sabado-Domingo 9:00am a 11:00pm";


                    //***********************************************************
                    context.Empleados.Add(Empleado1);
                    //************************************************************+
                    context.SaveChanges();
                
            }
                
        }
        private void ModificarDatos()
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    var Empleado1 = context.Empleados.First(x => x.Id == id);
                    if (Empleado1 != null)
                    {
                        Empleado1.Nombre = txtNombre.Text;
                        Empleado1.Apellido_Paterno = txtApellidoPa.Text;
                        Empleado1.Apellido_Materno = txtApellidoMaterno.Text;
                        Empleado1.Rol_Asignado = cbxRol.Text;
                        Empleado1.Salario = cbxSalario.Text;
                        Empleado1.Sexo = rbtFemenino.Checked ? "Femenino" : "Masculino";
                       // Empleado1.RFC = txtRFC.Text;
                        Empleado1.Fecha_Nacimiento = dtpFechaNacimiento.Value.Date;
                        Empleado1.Horario = chBxLunes.Checked ? "Lunes-Viernes 9:00pm a 1:00am" : "Sabado-Domingo 9:00am a 11:00pm";
                        context.SaveChanges();
                       
                    }
                }
            }
        }
        private void Aniquilar()
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    var Empleado1 = context.Empleados.First(x => x.Id == id);
                    if (Empleado1 != null)
                    {
                        context.Remove(Empleado1);
                        context.SaveChanges();

                    }
                }
            }
        }
        private void LimpiarTexto()
        {
            txtNombre.Text = "";
            txtApellidoPa.Text = "";
            txtApellidoMaterno.Text = "";
            txtBuscador.Text = "";
            txtRFC.Text = "";
            btnRegistrar.Enabled = true;
            txtRFC.Enabled=true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            LblRFC.Enabled = false;
        }
        private void BuscarClientes()
        {
            using (var context = new ApplicationDbContext())
            {
                var Empleado1 = context.Empleados.Where(x => x.Nombre.Contains(txtBuscador.Text)).ToList();
                dgvEmpleados.DataSource = Empleado1;
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellidoPa.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtApellidoMaterno.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            cbxRol.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();// lo de abajo 
            cbxSalario.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();//sera text o item??
            if (dgvEmpleados.CurrentRow.Cells[6].Value.ToString() == "Femenino")
            {
                rbtFemenino.Checked = true;
            }
            else
            {
                rbtMasculino.Checked = true;
            }
            // txtRFC.Text = dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells[8].Value.ToString());
            if (dgvEmpleados.CurrentRow.Cells[9].Value.ToString() == "Lunes-Viernes 9:00pm a 1:00am")//a ver si esto esta bien+++++++
            {
                chBxLunes.Checked = true;
            }
            else
            {
                chBxSabado.Checked = true;
            }
            btnRegistrar.Enabled = false;
            txtRFC.Enabled = false;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxRol.Text == "Otro...")
            {
                MessageBox.Show("Lo sentimos, por el momento solo tenemos esos puestos");
                btnRegistrar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            LblRFC.Enabled = true;
            using (var context = new ApplicationDbContext())
            {
               bool existe= context.Empleados.Any(x => x.RFC.Equals(txtRFC.Text));
                //preguntaremos si existe
                if (existe==true)
                {
                    //si no existe se agrega
                    MessageBox.Show("El RFC: "+txtRFC.Text+" ya a sido registrado, porfavor compruebelo");
                    btnRegistrar.Enabled=false;

                }
                else
                {
                   existe= false;
                    btnRegistrar.Enabled=true;
                    
                }
                
            }
        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            BuscarClientes();

        }
    }
}
