
namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    partial class Form_LoginCocina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LoginCocina));
            this.btnIniciarCocina = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbflechaSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarCocina
            // 
            this.btnIniciarCocina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarCocina.BackgroundImage")));
            this.btnIniciarCocina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarCocina.Location = new System.Drawing.Point(357, 488);
            this.btnIniciarCocina.Name = "btnIniciarCocina";
            this.btnIniciarCocina.Size = new System.Drawing.Size(224, 64);
            this.btnIniciarCocina.TabIndex = 0;
            this.btnIniciarCocina.UseVisualStyleBackColor = true;
            this.btnIniciarCocina.Click += new System.EventHandler(this.btnIniciarCocina_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(359, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Ingresa Tu Nombre";
            this.textBox1.Size = new System.Drawing.Size(222, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(359, 435);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.PlaceholderText = "Ingresa Contraseña";
            this.textBox2.Size = new System.Drawing.Size(222, 31);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(359, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 38);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña: ";
            // 
            // pbflechaSalir
            // 
            this.pbflechaSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbflechaSalir.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.flecha;
            this.pbflechaSalir.Location = new System.Drawing.Point(0, 637);
            this.pbflechaSalir.Name = "pbflechaSalir";
            this.pbflechaSalir.Size = new System.Drawing.Size(52, 49);
            this.pbflechaSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbflechaSalir.TabIndex = 84;
            this.pbflechaSalir.TabStop = false;
            this.pbflechaSalir.Click += new System.EventHandler(this.pbflechaSalir_Click);
            // 
            // Form_LoginCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 689);
            this.Controls.Add(this.pbflechaSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIniciarCocina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_LoginCocina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_LoginCocina";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarCocina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbflechaSalir;
    }
}