
namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    partial class Form_InicializandoInstalación
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InicializandoInstalación));
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.lblComentario = new System.Windows.Forms.Label();
            this.progreso = new System.Windows.Forms.Timer(this.components);
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.BtnMesero = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(820, 486);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(767, 50);
            this.pbProgreso.TabIndex = 5;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.BackColor = System.Drawing.Color.Transparent;
            this.lblComentario.Location = new System.Drawing.Point(50, 486);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(680, 50);
            this.lblComentario.TabIndex = 4;
            this.lblComentario.Text = "Iniciando Configuración Inicial...\r\nno apague ni desconectes el dispositivo mient" +
    "ras el software está en ejecución...[1/4]";
            this.lblComentario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComentario.Visible = false;
            // 
            // progreso
            // 
            this.progreso.Tick += new System.EventHandler(this.progreso_Tick);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAdmin.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.Captura_de_pantalla_2022_05_20_190252;
            this.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdmin.Location = new System.Drawing.Point(12, 132);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(367, 334);
            this.BtnAdmin.TabIndex = 6;
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnMesero
            // 
            this.BtnMesero.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.mesebrios;
            this.BtnMesero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMesero.Location = new System.Drawing.Point(413, 132);
            this.BtnMesero.Name = "BtnMesero";
            this.BtnMesero.Size = new System.Drawing.Size(367, 334);
            this.BtnMesero.TabIndex = 7;
            this.BtnMesero.UseVisualStyleBackColor = true;
            this.BtnMesero.Click += new System.EventHandler(this.BtnMesero_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.cocinebrios;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(820, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(367, 334);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.cajebrios;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(1225, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(367, 334);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modo Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(492, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vista Mesero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(911, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vista Cocina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(1335, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 41);
            this.label4.TabIndex = 13;
            this.label4.Text = "Vista Cajero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Violet;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(461, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(511, 54);
            this.label5.TabIndex = 14;
            this.label5.Text = "SELECCIONA UNA OPCIÓN:";
            // 
            // Form_InicializandoInstalación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1599, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnMesero);
            this.Controls.Add(this.BtnAdmin);
            this.Controls.Add(this.pbProgreso);
            this.Controls.Add(this.lblComentario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_InicializandoInstalación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializando";
            this.Load += new System.EventHandler(this.Form_InicializandoInstalación_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Timer progreso;
        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button BtnMesero;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

