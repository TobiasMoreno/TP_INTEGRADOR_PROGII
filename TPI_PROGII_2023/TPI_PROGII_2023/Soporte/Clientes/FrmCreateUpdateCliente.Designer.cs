namespace InmobiliariaFront.Soporte.Clientes
{
    partial class FrmCreateUpdateCliente
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
            lblCliente = new Label();
            lblInmobiliaria = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblCuil = new Label();
            txtCuil = new TextBox();
            label3 = new Label();
            txtDocumento = new TextBox();
            lblRegistro = new Label();
            dtpRegistro = new DateTimePicker();
            lblNacimiento = new Label();
            dtpNacimiento = new DateTimePicker();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            cboBarrio = new ComboBox();
            lblBarrio = new Label();
            label1 = new Label();
            txtNroDireccion = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblCliente.Location = new Point(10, 63);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(131, 25);
            lblCliente.TabIndex = 27;
            lblCliente.Text = "CLIENTE Nro:";
            // 
            // lblInmobiliaria
            // 
            lblInmobiliaria.AutoSize = true;
            lblInmobiliaria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmobiliaria.Location = new Point(12, 9);
            lblInmobiliaria.Name = "lblInmobiliaria";
            lblInmobiliaria.Size = new Size(93, 21);
            lblInmobiliaria.TabIndex = 26;
            lblInmobiliaria.Text = "Inmobiliaria";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(660, 23);
            txtNombre.TabIndex = 65;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 66;
            lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(12, 162);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(660, 23);
            txtApellido.TabIndex = 68;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(12, 144);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 67;
            lblApellido.Text = "Apellido";
            // 
            // lblCuil
            // 
            lblCuil.AutoSize = true;
            lblCuil.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuil.Location = new Point(354, 192);
            lblCuil.Name = "lblCuil";
            lblCuil.Size = new Size(32, 15);
            lblCuil.TabIndex = 77;
            lblCuil.Text = "CUIL";
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(354, 210);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(320, 23);
            txtCuil.TabIndex = 76;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 75;
            label3.Text = "Documento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(12, 210);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(322, 23);
            txtDocumento.TabIndex = 74;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistro.Location = new Point(354, 240);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(100, 15);
            lblRegistro.TabIndex = 81;
            lblRegistro.Text = "Fecha de Registro";
            // 
            // dtpRegistro
            // 
            dtpRegistro.Enabled = false;
            dtpRegistro.Location = new Point(354, 258);
            dtpRegistro.Name = "dtpRegistro";
            dtpRegistro.Size = new Size(318, 23);
            dtpRegistro.TabIndex = 80;
            // 
            // lblNacimiento
            // 
            lblNacimiento.AutoSize = true;
            lblNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNacimiento.Location = new Point(12, 240);
            lblNacimiento.Name = "lblNacimiento";
            lblNacimiento.Size = new Size(119, 15);
            lblNacimiento.TabIndex = 79;
            lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(12, 258);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(322, 23);
            dtpNacimiento.TabIndex = 78;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 354);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(320, 23);
            txtDireccion.TabIndex = 85;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(12, 336);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 84;
            lblDireccion.Text = "Direccion";
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(12, 306);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(660, 23);
            cboBarrio.TabIndex = 83;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarrio.Location = new Point(12, 288);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(38, 15);
            lblBarrio.TabIndex = 82;
            lblBarrio.Text = "Barrio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(354, 336);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 87;
            label1.Text = "Nro. Direccion";
            // 
            // txtNroDireccion
            // 
            txtNroDireccion.Location = new Point(354, 354);
            txtNroDireccion.Name = "txtNroDireccion";
            txtNroDireccion.Size = new Size(318, 23);
            txtNroDireccion.TabIndex = 86;
            txtNroDireccion.TextChanged += txtNroDireccion_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(354, 399);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(318, 23);
            btnGuardar.TabIndex = 88;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmCreateUpdateCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(txtNroDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(cboBarrio);
            Controls.Add(lblBarrio);
            Controls.Add(lblRegistro);
            Controls.Add(dtpRegistro);
            Controls.Add(lblNacimiento);
            Controls.Add(dtpNacimiento);
            Controls.Add(lblCuil);
            Controls.Add(txtCuil);
            Controls.Add(label3);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblCliente);
            Controls.Add(lblInmobiliaria);
            MaximizeBox = false;
            Name = "FrmCreateUpdateCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCreateUpdateCliente";
            FormClosed += FrmCreateUpdateCliente_FormClosed;
            Load += FrmCreateUpdateCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCliente;
        private Label lblInmobiliaria;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblCuil;
        private TextBox txtCuil;
        private Label label3;
        private TextBox txtDocumento;
        private Label lblRegistro;
        private DateTimePicker dtpRegistro;
        private Label lblNacimiento;
        private DateTimePicker dtpNacimiento;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private ComboBox cboBarrio;
        private Label lblBarrio;
        private Label label1;
        private TextBox txtNroDireccion;
        private Button btnGuardar;
    }
}