
namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    partial class Form_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbflechaSalir = new System.Windows.Forms.PictureBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnRol = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCaja = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.horaYfecha = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Pastel1 = new System.Windows.Forms.Label();
            this.pastel2 = new System.Windows.Forms.Label();
            this.pastel6 = new System.Windows.Forms.Label();
            this.pastel3 = new System.Windows.Forms.Label();
            this.pastel4 = new System.Windows.Forms.Label();
            this.pastel5 = new System.Windows.Forms.Label();
            this.pastel7 = new System.Windows.Forms.Label();
            this.pastel8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.lblusuario);
            this.panel2.Controls.Add(this.pbFoto);
            this.panel2.Controls.Add(this.btnRol);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnConfiguracion);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.BtnCaja);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 972);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pbflechaSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 923);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 49);
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
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblusuario.Location = new System.Drawing.Point(0, 139);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(149, 64);
            this.lblusuario.TabIndex = 23;
            this.lblusuario.Text = "bienvenido \r\n@usuario";
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.Captura_de_pantalla_2022_05_20_190252;
            this.pbFoto.Location = new System.Drawing.Point(0, 3);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 133);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRol
            // 
            this.btnRol.BackColor = System.Drawing.Color.LightCoral;
            this.btnRol.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.usuario;
            this.btnRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRol.Location = new System.Drawing.Point(3, 206);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(111, 115);
            this.btnRol.TabIndex = 2;
            this.btnRol.UseVisualStyleBackColor = false;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Orange;
            this.btnMenu.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.menu;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Location = new System.Drawing.Point(3, 410);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(111, 115);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 75);
            this.label2.TabIndex = 7;
            this.label2.Text = "AGREGAR/\r\nCONFIGURAR/\r\nELIMINAR ROLES\r\n";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.BlueViolet;
            this.btnConfiguracion.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.configuracion4;
            this.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracion.Location = new System.Drawing.Point(3, 772);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(111, 115);
            this.btnConfiguracion.TabIndex = 5;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 890);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "CONFIGURACIÓN\r\n";
            // 
            // BtnCaja
            // 
            this.BtnCaja.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCaja.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.caja;
            this.BtnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCaja.Location = new System.Drawing.Point(3, 585);
            this.BtnCaja.Name = "BtnCaja";
            this.BtnCaja.Size = new System.Drawing.Size(111, 115);
            this.BtnCaja.TabIndex = 4;
            this.BtnCaja.UseVisualStyleBackColor = false;
            this.BtnCaja.Click += new System.EventHandler(this.BtnCaja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = "AGREGAR/\r\nEDITAR MENU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 703);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 50);
            this.label4.TabIndex = 9;
            this.label4.Text = "CONSULTAR/\r\nCORTE DE CAJA\r\n";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.SystemColors.Control;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(639, 43);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(180, 74);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label3";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(633, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 25);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "label2";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(461, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 74);
            this.label8.TabIndex = 19;
            this.label8.Text = "01";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 612);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "MESAS ATENDIDAS:";
            // 
            // horaYfecha
            // 
            this.horaYfecha.Enabled = true;
            this.horaYfecha.Tick += new System.EventHandler(this.horaYfecha_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Imagen |*.jpg|Todos los Archivos|*.*";
            // 
            // Pastel1
            // 
            this.Pastel1.AutoSize = true;
            this.Pastel1.BackColor = System.Drawing.SystemColors.Control;
            this.Pastel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pastel1.Location = new System.Drawing.Point(1550, 697);
            this.Pastel1.Name = "Pastel1";
            this.Pastel1.Size = new System.Drawing.Size(78, 32);
            this.Pastel1.TabIndex = 23;
            this.Pastel1.Text = "label1";
            this.Pastel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pastel2
            // 
            this.pastel2.AutoSize = true;
            this.pastel2.BackColor = System.Drawing.SystemColors.Control;
            this.pastel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pastel2.Location = new System.Drawing.Point(1550, 729);
            this.pastel2.Name = "pastel2";
            this.pastel2.Size = new System.Drawing.Size(91, 32);
            this.pastel2.TabIndex = 24;
            this.pastel2.Text = "label10";
            this.pastel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pastel6
            // 
            this.pastel6.AutoSize = true;
            this.pastel6.BackColor = System.Drawing.SystemColors.Control;
            this.pastel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pastel6.Location = new System.Drawing.Point(1550, 856);
            this.pastel6.Name = "pastel6";
            this.pastel6.Size = new System.Drawing.Size(91, 32);
            this.pastel6.TabIndex = 25;
            this.pastel6.Text = "label11";
            this.pastel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pastel3
            // 
            this.pastel3.AutoSize = true;
            this.pastel3.BackColor = System.Drawing.SystemColors.Control;
            this.pastel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pastel3.Location = new System.Drawing.Point(1550, 761);
            this.pastel3.Name = "pastel3";
            this.pastel3.Size = new System.Drawing.Size(91, 32);
            this.pastel3.TabIndex = 26;
            this.pastel3.Text = "label12";
            this.pastel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pastel4
            // 
            this.pastel4.AutoSize = true;
            this.pastel4.BackColor = System.Drawing.SystemColors.Control;
            this.pastel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pastel4.Location = new System.Drawing.Point(1550, 792);
            this.pastel4.Name = "pastel4";
            this.pastel4.Size = new System.Drawing.Size(91, 32);
            this.pastel4.TabIndex = 27;
            this.pastel4.Text = "label13";
            this.pastel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pastel5
            // 
            this.pastel5.AutoSize = true;
            this.pastel5.BackColor = System.Drawing.SystemColors.Control;
            this.pastel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pastel5.Location = new System.Drawing.Point(1550, 824);
            this.pastel5.Name = "pastel5";
            this.pastel5.Size = new System.Drawing.Size(91, 32);
            this.pastel5.TabIndex = 28;
            this.pastel5.Text = "label13";
            this.pastel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pastel7
            // 
            this.pastel7.AutoSize = true;
            this.pastel7.BackColor = System.Drawing.SystemColors.Control;
            this.pastel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pastel7.Location = new System.Drawing.Point(1550, 888);
            this.pastel7.Name = "pastel7";
            this.pastel7.Size = new System.Drawing.Size(91, 32);
            this.pastel7.TabIndex = 29;
            this.pastel7.Text = "label13";
            this.pastel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pastel8
            // 
            this.pastel8.AutoSize = true;
            this.pastel8.BackColor = System.Drawing.SystemColors.Control;
            this.pastel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pastel8.Location = new System.Drawing.Point(1550, 920);
            this.pastel8.Name = "pastel8";
            this.pastel8.Size = new System.Drawing.Size(91, 32);
            this.pastel8.TabIndex = 30;
            this.pastel8.Text = "label13";
            this.pastel8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(674, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 54);
            this.label1.TabIndex = 24;
            this.label1.Text = "Productos mas vendidos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.caja_registradora;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(461, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 115);
            this.button1.TabIndex = 90;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.chefsito;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(570, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 115);
            this.button2.TabIndex = 91;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.meseroo;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(674, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 115);
            this.button3.TabIndex = 92;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(461, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(447, 54);
            this.label10.TabIndex = 93;
            this.label10.Text = "Indice de Rendimiento";
            // 
            // Form_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1578, 972);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pastel8);
            this.Controls.Add(this.pastel7);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pastel5);
            this.Controls.Add(this.pastel4);
            this.Controls.Add(this.pastel3);
            this.Controls.Add(this.pastel6);
            this.Controls.Add(this.pastel2);
            this.Controls.Add(this.Pastel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button BtnCaja;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer horaYfecha;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label Pastel1;
        private System.Windows.Forms.Label pastel2;
        private System.Windows.Forms.Label pastel6;
        private System.Windows.Forms.Label pastel3;
        private System.Windows.Forms.Label pastel4;
        private System.Windows.Forms.Label pastel5;
        private System.Windows.Forms.Label pastel7;
        private System.Windows.Forms.Label pastel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbflechaSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
    }
}