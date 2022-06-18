
namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    partial class Movil_Mesero_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movil_Mesero_Login));
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbflechaSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.Transparent;
            this.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagen.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.mesero;
            this.pbImagen.Location = new System.Drawing.Point(228, 37);
            this.pbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(143, 153);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 38;
            this.pbImagen.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Location = new System.Drawing.Point(228, 416);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 32);
            this.btnLogin.TabIndex = 43;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(206, 270);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PlaceholderText = "Nombre";
            this.txbUsuario.Size = new System.Drawing.Size(190, 31);
            this.txbUsuario.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(183, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Empleado Meser@:";
            // 
            // TxbPass
            // 
            this.TxbPass.Location = new System.Drawing.Point(206, 357);
            this.TxbPass.Margin = new System.Windows.Forms.Padding(2);
            this.TxbPass.Name = "TxbPass";
            this.TxbPass.PasswordChar = '*';
            this.TxbPass.PlaceholderText = "Password";
            this.TxbPass.Size = new System.Drawing.Size(190, 31);
            this.TxbPass.TabIndex = 44;
            this.TxbPass.TextChanged += new System.EventHandler(this.TxbPass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(221, 312);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 32);
            this.label2.TabIndex = 45;
            this.label2.Text = "Contraseña:";
            // 
            // pbflechaSalir
            // 
            this.pbflechaSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbflechaSalir.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.flecha;
            this.pbflechaSalir.Location = new System.Drawing.Point(-1, 449);
            this.pbflechaSalir.Name = "pbflechaSalir";
            this.pbflechaSalir.Size = new System.Drawing.Size(52, 49);
            this.pbflechaSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbflechaSalir.TabIndex = 84;
            this.pbflechaSalir.TabStop = false;
            this.pbflechaSalir.Click += new System.EventHandler(this.pbflechaSalir_Click);
            // 
            // Movil_Mesero_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.fondoMesero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 493);
            this.Controls.Add(this.pbflechaSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbPass);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Movil_Mesero_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbflechaSalir;
    }
}