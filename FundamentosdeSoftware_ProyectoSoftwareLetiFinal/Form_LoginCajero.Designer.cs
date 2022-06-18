
namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    partial class Form_LoginCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LoginCajero));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbPass = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIniciarCocina = new System.Windows.Forms.Button();
            this.pbflechaSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(309, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(322, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario:";
            // 
            // TxbPass
            // 
            this.TxbPass.Location = new System.Drawing.Point(309, 420);
            this.TxbPass.Name = "TxbPass";
            this.TxbPass.PasswordChar = '*';
            this.TxbPass.PlaceholderText = "Ingresa Contraseña";
            this.TxbPass.Size = new System.Drawing.Size(222, 31);
            this.TxbPass.TabIndex = 9;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(309, 300);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PlaceholderText = "Ingresa Tu Nombre";
            this.txbUsuario.Size = new System.Drawing.Size(222, 31);
            this.txbUsuario.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.cajebrios;
            this.pictureBox1.Location = new System.Drawing.Point(270, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnIniciarCocina
            // 
            this.btnIniciarCocina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarCocina.BackgroundImage")));
            this.btnIniciarCocina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarCocina.Location = new System.Drawing.Point(307, 473);
            this.btnIniciarCocina.Name = "btnIniciarCocina";
            this.btnIniciarCocina.Size = new System.Drawing.Size(224, 64);
            this.btnIniciarCocina.TabIndex = 6;
            this.btnIniciarCocina.UseVisualStyleBackColor = true;
            this.btnIniciarCocina.Click += new System.EventHandler(this.btnIniciarCocina_Click);
            // 
            // pbflechaSalir
            // 
            this.pbflechaSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbflechaSalir.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.flecha;
            this.pbflechaSalir.Location = new System.Drawing.Point(12, 507);
            this.pbflechaSalir.Name = "pbflechaSalir";
            this.pbflechaSalir.Size = new System.Drawing.Size(52, 49);
            this.pbflechaSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbflechaSalir.TabIndex = 84;
            this.pbflechaSalir.TabStop = false;
            this.pbflechaSalir.Click += new System.EventHandler(this.pbflechaSalir_Click);
            // 
            // Form_LoginCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.fondo_rojo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.pbflechaSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbPass);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIniciarCocina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_LoginCajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbPass;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIniciarCocina;
        private System.Windows.Forms.PictureBox pbflechaSalir;
    }
}