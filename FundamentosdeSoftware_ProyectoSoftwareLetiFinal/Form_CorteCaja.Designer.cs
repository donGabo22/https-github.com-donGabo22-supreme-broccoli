
namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    partial class Form_CorteCaja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CorteCaja));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvFinal = new System.Windows.Forms.DataGridView();
            this.lbldatetimepicker = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbflechaSalir = new System.Windows.Forms.PictureBox();
            this.lblfin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo de Texto |*.txt|Todos los Archivos|*.*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar registro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvFinal
            // 
            this.dgvFinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinal.Location = new System.Drawing.Point(12, 274);
            this.dgvFinal.Name = "dgvFinal";
            this.dgvFinal.RowHeadersWidth = 62;
            this.dgvFinal.RowTemplate.Height = 33;
            this.dgvFinal.Size = new System.Drawing.Size(1193, 325);
            this.dgvFinal.TabIndex = 1;
            this.dgvFinal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinal_CellContentClick);
            // 
            // lbldatetimepicker
            // 
            this.lbldatetimepicker.AutoSize = true;
            this.lbldatetimepicker.Location = new System.Drawing.Point(607, 96);
            this.lbldatetimepicker.Name = "lbldatetimepicker";
            this.lbldatetimepicker.Size = new System.Drawing.Size(59, 25);
            this.lbldatetimepicker.TabIndex = 2;
            this.lbldatetimepicker.Text = "label1";
            this.lbldatetimepicker.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(395, 31);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Finalizar Turno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pbflechaSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 632);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 49);
            this.panel1.TabIndex = 89;
            // 
            // pbflechaSalir
            // 
            this.pbflechaSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbflechaSalir.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.flecha;
            this.pbflechaSalir.Location = new System.Drawing.Point(0, 0);
            this.pbflechaSalir.Name = "pbflechaSalir";
            this.pbflechaSalir.Size = new System.Drawing.Size(52, 49);
            this.pbflechaSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbflechaSalir.TabIndex = 57;
            this.pbflechaSalir.TabStop = false;
            this.pbflechaSalir.Click += new System.EventHandler(this.pbflechaSalir_Click);
            // 
            // lblfin
            // 
            this.lblfin.AutoSize = true;
            this.lblfin.Location = new System.Drawing.Point(360, 192);
            this.lblfin.Name = "lblfin";
            this.lblfin.Size = new System.Drawing.Size(59, 25);
            this.lblfin.TabIndex = 90;
            this.lblfin.Text = "label1";
            this.lblfin.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.Captura_de_pantalla_2022_05_20_190252;
            this.pictureBox1.Location = new System.Drawing.Point(909, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 92;
            this.label1.Text = "INGRESOS OBTENIDOS:";
            this.label1.Visible = false;
            // 
            // Form_CorteCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1205, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblfin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldatetimepicker);
            this.Controls.Add(this.dgvFinal);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_CorteCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corte de Caja";
            this.Load += new System.EventHandler(this.Form_CorteCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvFinal;
        private System.Windows.Forms.Label lbldatetimepicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbflechaSalir;
        private System.Windows.Forms.Label lblfin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}