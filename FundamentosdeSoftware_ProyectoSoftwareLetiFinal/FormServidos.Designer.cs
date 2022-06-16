namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    partial class FormServidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarPlatillo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscarBebida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvPlatillo = new System.Windows.Forms.DataGridView();
            this.DgvBebida = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombrePlatillo = new System.Windows.Forms.Label();
            this.lblCaracterPlatillo = new System.Windows.Forms.Label();
            this.LblPrecioPlatillo = new System.Windows.Forms.Label();
            this.txtCantidadPlatillo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantidadBebida = new System.Windows.Forms.TextBox();
            this.LblPrecioBbebida = new System.Windows.Forms.Label();
            this.LblCaracterBbebida = new System.Windows.Forms.Label();
            this.lblNombreBebida = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvMesero = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlatillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBebida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 37);
            this.label1.TabIndex = 92;
            this.label1.Text = "Mesero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(741, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 93;
            this.label2.Text = "Pedido:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(834, 57);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(100, 23);
            this.txtPedido.TabIndex = 94;
            this.txtPedido.TextChanged += new System.EventHandler(this.txtPedido_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.mesebrios;
            this.pictureBox1.Location = new System.Drawing.Point(741, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarPlatillo
            // 
            this.txtBuscarPlatillo.Location = new System.Drawing.Point(128, 52);
            this.txtBuscarPlatillo.Name = "txtBuscarPlatillo";
            this.txtBuscarPlatillo.Size = new System.Drawing.Size(212, 23);
            this.txtBuscarPlatillo.TabIndex = 99;
            this.txtBuscarPlatillo.TextChanged += new System.EventHandler(this.txtBuscarPlatillo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 21);
            this.label4.TabIndex = 98;
            this.label4.Text = "Buscar Platillo:";
            // 
            // txtBuscarBebida
            // 
            this.txtBuscarBebida.Location = new System.Drawing.Point(492, 52);
            this.txtBuscarBebida.Name = "txtBuscarBebida";
            this.txtBuscarBebida.Size = new System.Drawing.Size(221, 23);
            this.txtBuscarBebida.TabIndex = 101;
            this.txtBuscarBebida.TextChanged += new System.EventHandler(this.txtBuscarBebida_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(378, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 100;
            this.label3.Text = "Buscar Bebida:";
            // 
            // DgvPlatillo
            // 
            this.DgvPlatillo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlatillo.Location = new System.Drawing.Point(17, 94);
            this.DgvPlatillo.Name = "DgvPlatillo";
            this.DgvPlatillo.RowTemplate.Height = 25;
            this.DgvPlatillo.Size = new System.Drawing.Size(323, 101);
            this.DgvPlatillo.TabIndex = 102;
            this.DgvPlatillo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPlatillo_CellContentClick);
            // 
            // DgvBebida
            // 
            this.DgvBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBebida.Location = new System.Drawing.Point(378, 94);
            this.DgvBebida.Name = "DgvBebida";
            this.DgvBebida.RowTemplate.Height = 25;
            this.DgvBebida.Size = new System.Drawing.Size(335, 101);
            this.DgvBebida.TabIndex = 103;
            this.DgvBebida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBebida_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(17, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 110;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(17, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 111;
            this.label6.Text = "Caracteristicas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(17, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 112;
            this.label7.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(17, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 113;
            this.label8.Text = "Cantidad:";
            // 
            // lblNombrePlatillo
            // 
            this.lblNombrePlatillo.AutoSize = true;
            this.lblNombrePlatillo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombrePlatillo.Location = new System.Drawing.Point(130, 230);
            this.lblNombrePlatillo.Name = "lblNombrePlatillo";
            this.lblNombrePlatillo.Size = new System.Drawing.Size(17, 15);
            this.lblNombrePlatillo.TabIndex = 114;
            this.lblNombrePlatillo.Text = "--";
            // 
            // lblCaracterPlatillo
            // 
            this.lblCaracterPlatillo.AutoSize = true;
            this.lblCaracterPlatillo.BackColor = System.Drawing.Color.Transparent;
            this.lblCaracterPlatillo.Location = new System.Drawing.Point(130, 269);
            this.lblCaracterPlatillo.Name = "lblCaracterPlatillo";
            this.lblCaracterPlatillo.Size = new System.Drawing.Size(17, 15);
            this.lblCaracterPlatillo.TabIndex = 115;
            this.lblCaracterPlatillo.Text = "--";
            // 
            // LblPrecioPlatillo
            // 
            this.LblPrecioPlatillo.AutoSize = true;
            this.LblPrecioPlatillo.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecioPlatillo.Location = new System.Drawing.Point(130, 309);
            this.LblPrecioPlatillo.Name = "LblPrecioPlatillo";
            this.LblPrecioPlatillo.Size = new System.Drawing.Size(17, 15);
            this.LblPrecioPlatillo.TabIndex = 117;
            this.LblPrecioPlatillo.Text = "--";
            // 
            // txtCantidadPlatillo
            // 
            this.txtCantidadPlatillo.Location = new System.Drawing.Point(130, 345);
            this.txtCantidadPlatillo.Name = "txtCantidadPlatillo";
            this.txtCantidadPlatillo.Size = new System.Drawing.Size(63, 23);
            this.txtCantidadPlatillo.TabIndex = 118;
            this.txtCantidadPlatillo.TextChanged += new System.EventHandler(this.txtCantidadPlatillo_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(95, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 15);
            this.label11.TabIndex = 119;
            this.label11.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(58, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 120;
            this.label13.Text = "Platillo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(419, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 130;
            this.label14.Text = "Bebida:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(456, 309);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 129;
            this.label15.Text = "$";
            // 
            // txtCantidadBebida
            // 
            this.txtCantidadBebida.Location = new System.Drawing.Point(491, 345);
            this.txtCantidadBebida.Name = "txtCantidadBebida";
            this.txtCantidadBebida.Size = new System.Drawing.Size(63, 23);
            this.txtCantidadBebida.TabIndex = 128;
            this.txtCantidadBebida.TextChanged += new System.EventHandler(this.txtCantidadBebida_TextChanged);
            // 
            // LblPrecioBbebida
            // 
            this.LblPrecioBbebida.AutoSize = true;
            this.LblPrecioBbebida.BackColor = System.Drawing.Color.Transparent;
            this.LblPrecioBbebida.Location = new System.Drawing.Point(491, 309);
            this.LblPrecioBbebida.Name = "LblPrecioBbebida";
            this.LblPrecioBbebida.Size = new System.Drawing.Size(17, 15);
            this.LblPrecioBbebida.TabIndex = 127;
            this.LblPrecioBbebida.Text = "--";
            // 
            // LblCaracterBbebida
            // 
            this.LblCaracterBbebida.AutoSize = true;
            this.LblCaracterBbebida.BackColor = System.Drawing.Color.Transparent;
            this.LblCaracterBbebida.Location = new System.Drawing.Point(491, 269);
            this.LblCaracterBbebida.Name = "LblCaracterBbebida";
            this.LblCaracterBbebida.Size = new System.Drawing.Size(17, 15);
            this.LblCaracterBbebida.TabIndex = 126;
            this.LblCaracterBbebida.Text = "--";
            // 
            // lblNombreBebida
            // 
            this.lblNombreBebida.AutoSize = true;
            this.lblNombreBebida.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreBebida.Location = new System.Drawing.Point(491, 230);
            this.lblNombreBebida.Name = "lblNombreBebida";
            this.lblNombreBebida.Size = new System.Drawing.Size(17, 15);
            this.lblNombreBebida.TabIndex = 125;
            this.lblNombreBebida.Text = "--";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(378, 348);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 15);
            this.label19.TabIndex = 124;
            this.label19.Text = "Cantidad:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(378, 309);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 15);
            this.label20.TabIndex = 123;
            this.label20.Text = "Precio:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(378, 269);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 122;
            this.label21.Text = "Caracteristicas:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(378, 230);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 15);
            this.label22.TabIndex = 121;
            this.label22.Text = "Nombre:";
            // 
            // dgvMesero
            // 
            this.dgvMesero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesero.Location = new System.Drawing.Point(17, 381);
            this.dgvMesero.Name = "dgvMesero";
            this.dgvMesero.RowTemplate.Height = 25;
            this.dgvMesero.Size = new System.Drawing.Size(990, 105);
            this.dgvMesero.TabIndex = 131;
            this.dgvMesero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMesero_CellContentClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(815, 319);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(164, 23);
            this.btnLimpiar.TabIndex = 139;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(815, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 23);
            this.btnEliminar.TabIndex = 138;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(622, 319);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(176, 23);
            this.btnRegistrar.TabIndex = 137;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(622, 348);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(176, 23);
            this.btnModificar.TabIndex = 136;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FormServidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 498);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvMesero);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtCantidadBebida);
            this.Controls.Add(this.LblPrecioBbebida);
            this.Controls.Add(this.LblCaracterBbebida);
            this.Controls.Add(this.lblNombreBebida);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCantidadPlatillo);
            this.Controls.Add(this.LblPrecioPlatillo);
            this.Controls.Add(this.lblCaracterPlatillo);
            this.Controls.Add(this.lblNombrePlatillo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DgvBebida);
            this.Controls.Add(this.DgvPlatillo);
            this.Controls.Add(this.txtBuscarBebida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscarPlatillo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormServidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormServidos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlatillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBebida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarPlatillo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscarBebida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvPlatillo;
        private System.Windows.Forms.DataGridView DgvBebida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNombrePlatillo;
        private System.Windows.Forms.Label lblCaracterPlatillo;
        private System.Windows.Forms.Label LblPrecioPlatillo;
        private System.Windows.Forms.TextBox txtCantidadPlatillo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCantidadBebida;
        private System.Windows.Forms.Label LblPrecioBbebida;
        private System.Windows.Forms.Label LblCaracterBbebida;
        private System.Windows.Forms.Label lblNombreBebida;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dgvMesero;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
    }
}