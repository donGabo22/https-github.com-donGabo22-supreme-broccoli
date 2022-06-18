using FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    public partial class Form_CorteCaja : Form
    {
        private object rtxt_contenido;
        public StreamWriter escritor;

        public Form_CorteCaja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    //codigo
            //  lblfin.Text  =    saveFileDialog1.FileName;
            //}

            //try
            //{
            //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        if (File.Exists(saveFileDialog1.FileName))
            //        {
            //            string txt = saveFileDialog1.FileName;
            //            StreamWriter txtoaguardar = File.CreateText(txt);
            //           // txtoaguardar.Write(rtxt_contenido.);
            //            txtoaguardar.Flush();
            //            txtoaguardar.Close();


            //        }
            //    }
            //}

            //catch (Exception)
            //{
            //    MessageBox.Show("Error al guardar");
            //}
            saveFileDialog1.ShowDialog();
            //creamos el archivo de texto en la ruta del save dialog
            escritor = new StreamWriter(saveFileDialog1.FileName);
            for (int i = 0; i < 1; i++)
            {
                escritor.WriteLine("********QUERRY SOFTWARE****************************");

                escritor.WriteLine("Ingresos Obtenidos el 17 de Junio del 2022 es: "+lblfin.Text);     
                    
            

            }

            escritor.Close();


        }

        private void dgvFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TodosPedidos()
        {
            using (var context = new ApplicationDbContext())
            {
                var pedido = context.MServidor.ToList();
                dgvFinal.DataSource = pedido;
            }
        }

        private void Form_CorteCaja_Load(object sender, EventArgs e)
        {
            TodosPedidos();

        }

        public void esotilin()
        {

            
            
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("select SUM(TotalF) as 'TOTAL' from Registradora where YEAR(Fecha_Venta)='" + lbldatetimepicker.Text + "' and MONTH(Fecha_Venta)='" + label2.Text + "' and DAY(Fecha_Venta)='" + label3.Text + "'", conexion))
                    {

                    label1.Visible = true;
                    lblfin.Visible = true;
                        lblfin.Text = cmd.ExecuteScalar().ToString();






                    

                
            
                }
    }

            }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;
             
            lbldatetimepicker.Text = fecha.Year.ToString();
            label2.Text = fecha.Month.ToString();
            label3.Text = fecha.Day.ToString();






        }
        public class Example
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            esotilin();
        }

        private void pbflechaSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
