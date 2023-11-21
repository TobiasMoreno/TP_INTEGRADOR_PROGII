namespace InmobiliariaFront.Soporte.Clientes
{
    partial class FrmSoporteClientes
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
            btnSalir = new Button();
            btnAgregar = new Button();
            lblResultados = new Label();
            lblClientes = new Label();
            lblGestionar = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvClientes = new DataGridView();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 646);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 23);
            btnSalir.TabIndex = 54;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1097, 111);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 23);
            btnAgregar.TabIndex = 53;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultados.Location = new Point(12, 112);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(102, 25);
            lblResultados.TabIndex = 52;
            lblResultados.Text = "Resultados";
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.BackColor = Color.Navy;
            lblClientes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientes.ForeColor = Color.White;
            lblClientes.Location = new Point(12, 48);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(79, 25);
            lblClientes.TabIndex = 50;
            lblClientes.Text = "Clientes";
            // 
            // lblGestionar
            // 
            lblGestionar.AutoSize = true;
            lblGestionar.BackColor = Color.Navy;
            lblGestionar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblGestionar.ForeColor = Color.White;
            lblGestionar.Location = new Point(12, 23);
            lblGestionar.Name = "lblGestionar";
            lblGestionar.Size = new Size(118, 25);
            lblGestionar.TabIndex = 49;
            lblGestionar.Text = "GESTIONAR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 100);
            panel1.TabIndex = 59;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Texto;
            pictureBox1.Location = new Point(1152, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1095, 646);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 23);
            btnEditar.TabIndex = 84;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(934, 646);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 23);
            btnEliminar.TabIndex = 85;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { CodCliente, ColNombre, ColApellido, ColFechaNacimiento, ColDocumento, ColCuil, ColFechaRegistro, ColBarrio, ColDireccion, ColNroDireccion });
            dgvClientes.Location = new Point(12, 140);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(1238, 500);
            dgvClientes.TabIndex = 86;
            // 
            // CodCliente
            // 
            CodCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CodCliente.HeaderText = "Cliente";
            CodCliente.Name = "CodCliente";
            CodCliente.ReadOnly = true;
            CodCliente.Visible = false;
            // 
            // ColNombre
            // 
            ColNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColApellido
            // 
            ColApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColApellido.HeaderText = "Apellido";
            ColApellido.Name = "ColApellido";
            ColApellido.ReadOnly = true;
            // 
            // ColFechaNacimiento
            // 
            ColFechaNacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFechaNacimiento.HeaderText = "Fecha de Nacimiento";
            ColFechaNacimiento.Name = "ColFechaNacimiento";
            ColFechaNacimiento.ReadOnly = true;
            // 
            // ColDocumento
            // 
            ColDocumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDocumento.HeaderText = "Documento";
            ColDocumento.Name = "ColDocumento";
            ColDocumento.ReadOnly = true;
            // 
            // ColCuil
            // 
            ColCuil.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCuil.HeaderText = "CUIL";
            ColCuil.Name = "ColCuil";
            ColCuil.ReadOnly = true;
            // 
            // ColFechaRegistro
            // 
            ColFechaRegistro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFechaRegistro.HeaderText = "Fecha de Registro";
            ColFechaRegistro.Name = "ColFechaRegistro";
            ColFechaRegistro.ReadOnly = true;
            // 
            // ColBarrio
            // 
            ColBarrio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColBarrio.HeaderText = "Barrio";
            ColBarrio.Name = "ColBarrio";
            ColBarrio.ReadOnly = true;
            // 
            // ColDireccion
            // 
            ColDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDireccion.HeaderText = "Direccion";
            ColDireccion.Name = "ColDireccion";
            ColDireccion.ReadOnly = true;
            // 
            // ColNroDireccion
            // 
            ColNroDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNroDireccion.HeaderText = "N°Direccion";
            ColNroDireccion.Name = "ColNroDireccion";
            ColNroDireccion.ReadOnly = true;
            // 
            // FrmSoporteClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(lblResultados);
            Controls.Add(lblClientes);
            Controls.Add(lblGestionar);
            Controls.Add(panel1);
            MinimizeBox = false;
            Name = "FrmSoporteClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSoporteClientes";
            Load += FrmSoporteClientes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalir;
        private Button btnAgregar;
        private Label lblResultados;
        private Label lblClientes;
        private Label lblGestionar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private NumericUpDown numAñoHasta;
        private Label lblAñoHasta;
        private NumericUpDown numAñoDesde;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvClientes;
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
    }
}