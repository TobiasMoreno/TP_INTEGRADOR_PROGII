namespace InmobiliariaFront.ABM
{
    partial class FrmCliente
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
            label1 = new Label();
            lblInmobiliaria = new Label();
            dgvClientes = new DataGridView();
            btnAgregar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            txtDocumento = new TextBox();
            txtCuil = new TextBox();
            lblDoc = new Label();
            lblCuil = new Label();
            lblFechaRegistro = new Label();
            dtpFechaRegistro = new DateTimePicker();
            cboBarrio = new ComboBox();
            lblBarrio = new Label();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblAltura = new Label();
            txtNroDireccion = new TextBox();
            lblInquilinosDeudores = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            CodCliente = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColApellido = new DataGridViewTextBoxColumn();
            ColFechaNacimiento = new DataGridViewTextBoxColumn();
            ColDocumento = new DataGridViewTextBoxColumn();
            ColCuil = new DataGridViewTextBoxColumn();
            ColFechaRegistro = new DataGridViewTextBoxColumn();
            ColBarrio = new DataGridViewTextBoxColumn();
            ColDireccion = new DataGridViewTextBoxColumn();
            ColNroDireccion = new DataGridViewTextBoxColumn();
            BtnEliminar = new DataGridViewButtonColumn();
            BtnActualizar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1167, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 9;
            label1.Text = "Fecha: 04/11/2023";
            // 
            // lblInmobiliaria
            // 
            lblInmobiliaria.AutoSize = true;
            lblInmobiliaria.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmobiliaria.ForeColor = Color.White;
            lblInmobiliaria.Location = new Point(13, 9);
            lblInmobiliaria.Name = "lblInmobiliaria";
            lblInmobiliaria.Size = new Size(126, 30);
            lblInmobiliaria.TabIndex = 10;
            lblInmobiliaria.Text = "Inmobiliaria";
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { CodCliente, ColNombre, ColApellido, ColFechaNacimiento, ColDocumento, ColCuil, ColFechaRegistro, ColBarrio, ColDireccion, ColNroDireccion, BtnEliminar, BtnActualizar });
            dgvClientes.Location = new Point(15, 383);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(1269, 424);
            dgvClientes.TabIndex = 22;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(964, 333);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(320, 23);
            btnAgregar.TabIndex = 26;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(964, 826);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(320, 23);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(15, 826);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(320, 23);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 167);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 23);
            txtNombre.TabIndex = 30;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(352, 167);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(320, 23);
            txtApellido.TabIndex = 31;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(355, 143);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 21);
            lblApellido.TabIndex = 32;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(15, 143);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 21);
            lblNombre.TabIndex = 33;
            lblNombre.Text = "Nombre";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(742, 167);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(158, 23);
            dtpFechaNacimiento.TabIndex = 34;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaNacimiento.Location = new Point(739, 143);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(155, 21);
            lblFechaNacimiento.TabIndex = 35;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(15, 222);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(320, 23);
            txtDocumento.TabIndex = 36;
            // 
            // txtCuil
            // 
            txtCuil.Location = new Point(352, 222);
            txtCuil.Name = "txtCuil";
            txtCuil.Size = new Size(320, 23);
            txtCuil.TabIndex = 37;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoc.Location = new Point(15, 198);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new Size(91, 21);
            lblDoc.TabIndex = 38;
            lblDoc.Text = "Documento";
            // 
            // lblCuil
            // 
            lblCuil.AutoSize = true;
            lblCuil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCuil.Location = new Point(355, 198);
            lblCuil.Name = "lblCuil";
            lblCuil.Size = new Size(43, 21);
            lblCuil.TabIndex = 39;
            lblCuil.Text = "CUIL";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaRegistro.Location = new Point(745, 198);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(133, 21);
            lblFechaRegistro.TabIndex = 41;
            lblFechaRegistro.Text = "Fecha de Registro";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            dtpFechaRegistro.Location = new Point(745, 222);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(155, 23);
            dtpFechaRegistro.TabIndex = 40;
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(15, 291);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(320, 23);
            cboBarrio.TabIndex = 42;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarrio.Location = new Point(15, 267);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(52, 21);
            lblBarrio.TabIndex = 43;
            lblBarrio.Text = "Barrio";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(355, 267);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 21);
            lblDireccion.TabIndex = 45;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(352, 291);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(320, 23);
            txtDireccion.TabIndex = 44;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAltura.Location = new Point(742, 267);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(97, 21);
            lblAltura.TabIndex = 47;
            lblAltura.Text = "N° Direccion";
            // 
            // txtNroDireccion
            // 
            txtNroDireccion.Location = new Point(742, 291);
            txtNroDireccion.Name = "txtNroDireccion";
            txtNroDireccion.Size = new Size(155, 23);
            txtNroDireccion.TabIndex = 46;
            // 
            // lblInquilinosDeudores
            // 
            lblInquilinosDeudores.AutoSize = true;
            lblInquilinosDeudores.BackColor = Color.Navy;
            lblInquilinosDeudores.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInquilinosDeudores.ForeColor = Color.White;
            lblInquilinosDeudores.Location = new Point(13, 44);
            lblInquilinosDeudores.Name = "lblInquilinosDeudores";
            lblInquilinosDeudores.Size = new Size(79, 25);
            lblInquilinosDeudores.TabIndex = 49;
            lblInquilinosDeudores.Text = "Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(lblInquilinosDeudores);
            panel1.Controls.Add(lblInmobiliaria);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 91);
            panel1.TabIndex = 50;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Navy;
            pictureBox1.Image = Properties.Resources.Texto;
            pictureBox1.Location = new Point(964, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CodCliente
            // 
            CodCliente.HeaderText = "";
            CodCliente.Name = "CodCliente";
            CodCliente.Width = 50;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            // 
            // ColApellido
            // 
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            // 
            // ColFechaNacimiento
            // 
            ColFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            ColFechaNacimiento.Name = "ColFechaNacimiento";
            // 
            // ColDocumento
            // 
            ColDocumento.HeaderText = "Documento";
            ColDocumento.Name = "ColDocumento";
            // 
            // ColCuil
            // 
            ColCuil.HeaderText = "CUIL";
            ColCuil.Name = "ColCuil";
            // 
            // ColFechaRegistro
            // 
            ColFechaRegistro.HeaderText = "Fecha de Registro";
            ColFechaRegistro.Name = "ColFechaRegistro";
            // 
            // ColBarrio
            // 
            ColBarrio.HeaderText = "Barrio";
            ColBarrio.Name = "ColBarrio";
            // 
            // ColDireccion
            // 
            ColDireccion.HeaderText = "Direccion";
            ColDireccion.Name = "ColDireccion";
            // 
            // ColNroDireccion
            // 
            ColNroDireccion.HeaderText = "N°Direccion";
            ColNroDireccion.Name = "ColNroDireccion";
            // 
            // BtnEliminar
            // 
            BtnEliminar.HeaderText = "Eliminar";
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Text = "Eliminar";
            // 
            // BtnActualizar
            // 
            BtnActualizar.HeaderText = "Actualizar";
            BtnActualizar.Name = "BtnActualizar";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 861);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblAltura);
            Controls.Add(txtNroDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblBarrio);
            Controls.Add(cboBarrio);
            Controls.Add(lblFechaRegistro);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(lblCuil);
            Controls.Add(lblDoc);
            Controls.Add(txtCuil);
            Controls.Add(txtDocumento);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(lblNombre);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvClientes);
            Name = "FrmCliente";
            Text = "FrmGenerarCliente";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblInmobiliaria;
        private DataGridView dgvClientes;
        private Button btnAgregar;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblNombre;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private TextBox txtDocumento;
        private TextBox txtCuil;
        private Label lblDoc;
        private Label lblCuil;
        private Label lblFechaRegistro;
        private DateTimePicker dtpFechaRegistro;
        private ComboBox cboBarrio;
        private Label lblBarrio;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblAltura;
        private TextBox txtNroDireccion;
        private Label lblInquilinosDeudores;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn CodCliente;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColApellido;
        private DataGridViewTextBoxColumn ColFechaNacimiento;
        private DataGridViewTextBoxColumn ColDocumento;
        private DataGridViewTextBoxColumn ColCuil;
        private DataGridViewTextBoxColumn ColFechaRegistro;
        private DataGridViewTextBoxColumn ColBarrio;
        private DataGridViewTextBoxColumn ColDireccion;
        private DataGridViewTextBoxColumn ColNroDireccion;
        private DataGridViewButtonColumn BtnEliminar;
        private DataGridViewButtonColumn BtnActualizar;
    }
}