namespace FundamentosdeSoftware_ProyectoSoftwareLetiFinal
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.chBxSabado = new System.Windows.Forms.CheckBox();
            this.chBxLunes = new System.Windows.Forms.CheckBox();
            this.MCalendario = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxSalario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtApellidoPa = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblRFC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbflechaSalir = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // chBxSabado
            // 
            this.chBxSabado.AutoSize = true;
            this.chBxSabado.BackColor = System.Drawing.Color.Transparent;
            this.chBxSabado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chBxSabado.Location = new System.Drawing.Point(1110, 352);
            this.chBxSabado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBxSabado.Name = "chBxSabado";
            this.chBxSabado.Size = new System.Drawing.Size(384, 32);
            this.chBxSabado.TabIndex = 74;
            this.chBxSabado.Text = "Sabado-Domingo 9:00am a 11:00pm";
            this.chBxSabado.UseVisualStyleBackColor = false;
            // 
            // chBxLunes
            // 
            this.chBxLunes.AutoSize = true;
            this.chBxLunes.BackColor = System.Drawing.Color.Transparent;
            this.chBxLunes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chBxLunes.Location = new System.Drawing.Point(1110, 310);
            this.chBxLunes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBxLunes.Name = "chBxLunes";
            this.chBxLunes.Size = new System.Drawing.Size(340, 32);
            this.chBxLunes.TabIndex = 73;
            this.chBxLunes.Text = "Lunes-Viernes 9:00pm a 1:00am";
            this.chBxLunes.UseVisualStyleBackColor = false;
            // 
            // MCalendario
            // 
            this.MCalendario.Location = new System.Drawing.Point(1110, 3);
            this.MCalendario.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            this.MCalendario.Name = "MCalendario";
            this.MCalendario.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1110, 277);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 28);
            this.label10.TabIndex = 71;
            this.label10.Text = "Horarios y dias de trabajo:";
            // 
            // cbxSalario
            // 
            this.cbxSalario.FormattingEnabled = true;
            this.cbxSalario.Items.AddRange(new object[] {
            "$ 1500 (Mil quinientos pesos MXN)",
            "$ 2000 (Dos mil pesos MXN)",
            "$2500 (Dos mil quinientos pesos MXN)"});
            this.cbxSalario.Location = new System.Drawing.Point(174, 282);
            this.cbxSalario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxSalario.Name = "cbxSalario";
            this.cbxSalario.Size = new System.Drawing.Size(171, 33);
            this.cbxSalario.TabIndex = 70;
            this.cbxSalario.Text = "Salario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 28);
            this.label9.TabIndex = 69;
            this.label9.Text = "Salario:";
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Items.AddRange(new object[] {
            "Mesero",
            "Cajero",
            "Chef",
            "Otro..."});
            this.cbxRol.Location = new System.Drawing.Point(174, 225);
            this.cbxRol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(374, 33);
            this.cbxRol.TabIndex = 68;
            this.cbxRol.Text = "Selecciona la ocupacion del empleado";
            this.cbxRol.SelectedIndexChanged += new System.EventHandler(this.cbxRol_SelectedIndexChanged);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(763, 238);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(277, 31);
            this.dtpFechaNacimiento.TabIndex = 66;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(174, 330);
            this.txtBuscador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(374, 31);
            this.txtBuscador.TabIndex = 65;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rbtMasculino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtMasculino.Location = new System.Drawing.Point(914, 57);
            this.rbtMasculino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(134, 32);
            this.rbtMasculino.TabIndex = 64;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = false;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rbtFemenino.Checked = true;
            this.rbtFemenino.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtFemenino.Location = new System.Drawing.Point(634, 57);
            this.rbtFemenino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(129, 32);
            this.rbtFemenino.TabIndex = 63;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = false;
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(634, 120);
            this.txtRFC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(405, 31);
            this.txtRFC.TabIndex = 62;
            this.txtRFC.TextChanged += new System.EventHandler(this.txtRFC_TextChanged);
            // 
            // txtApellidoPa
            // 
            this.txtApellidoPa.Location = new System.Drawing.Point(174, 122);
            this.txtApellidoPa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidoPa.Name = "txtApellidoPa";
            this.txtApellidoPa.Size = new System.Drawing.Size(374, 31);
            this.txtApellidoPa.TabIndex = 61;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 60);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(374, 31);
            this.txtNombre.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(557, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 28);
            this.label8.TabIndex = 59;
            this.label8.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(557, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 28);
            this.label7.TabIndex = 58;
            this.label7.Text = "RFC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(560, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 28);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fecha de nacimiento:";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(27, 405);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 62;
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.Size = new System.Drawing.Size(1100, 440);
            this.dgvEmpleados.TabIndex = 56;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 55;
            this.label5.Text = "Nombre(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 28);
            this.label4.TabIndex = 54;
            this.label4.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Rol a asignar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 52;
            this.label2.Text = "Buscador :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 47);
            this.label1.TabIndex = 51;
            this.label1.Text = "Empleados";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(174, 177);
            this.txtApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(374, 31);
            this.txtApellidoMaterno.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 28);
            this.label11.TabIndex = 75;
            this.label11.Text = "Apellido Materno:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(1136, 437);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(354, 38);
            this.btnRegistrar.TabIndex = 77;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1136, 533);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(354, 38);
            this.btnEliminar.TabIndex = 78;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1136, 485);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(354, 38);
            this.btnModificar.TabIndex = 79;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1136, 582);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(354, 38);
            this.btnLimpiar.TabIndex = 80;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.Captura_de_pantalla_2022_05_20_190252;
            this.pictureBox1.Location = new System.Drawing.Point(1136, 630);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // LblRFC
            // 
            this.LblRFC.AutoSize = true;
            this.LblRFC.BackColor = System.Drawing.Color.Transparent;
            this.LblRFC.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblRFC.Location = new System.Drawing.Point(634, 163);
            this.LblRFC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRFC.Name = "LblRFC";
            this.LblRFC.Size = new System.Drawing.Size(368, 46);
            this.LblRFC.TabIndex = 82;
            this.LblRFC.Text = "Nota: Compruebe si su RFC es correcto,\r\n una vez registrado ya no se podra modifi" +
    "car\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pbflechaSalir);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 797);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 68);
            this.panel1.TabIndex = 90;
            // 
            // pbflechaSalir
            // 
            this.pbflechaSalir.BackColor = System.Drawing.Color.Transparent;
            this.pbflechaSalir.Image = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.flecha;
            this.pbflechaSalir.Location = new System.Drawing.Point(0, 0);
            this.pbflechaSalir.Name = "pbflechaSalir";
            this.pbflechaSalir.Size = new System.Drawing.Size(52, 70);
            this.pbflechaSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbflechaSalir.TabIndex = 57;
            this.pbflechaSalir.TabStop = false;
            this.pbflechaSalir.Click += new System.EventHandler(this.pbflechaSalir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1180, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 65);
            this.button1.TabIndex = 67;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1490, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblRFC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtApellidoMaterno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chBxSabado);
            this.Controls.Add(this.chBxLunes);
            this.Controls.Add(this.MCalendario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbxSalario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxRol);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.txtRFC);
            this.Controls.Add(this.txtApellidoPa);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbflechaSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chBxSabado;
        private System.Windows.Forms.CheckBox chBxLunes;
        private System.Windows.Forms.MonthCalendar MCalendario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxSalario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtApellidoPa;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblRFC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbflechaSalir;
        private System.Windows.Forms.Button button1;
    }
}