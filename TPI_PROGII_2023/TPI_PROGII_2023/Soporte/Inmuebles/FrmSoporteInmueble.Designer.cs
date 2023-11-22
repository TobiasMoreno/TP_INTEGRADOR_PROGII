namespace InmobiliariaFront.Soporte.Inmuebles
{
    partial class FrmSoporteInmueble
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
            dgvInmuebles = new DataGridView();
            CodInmueble = new DataGridViewTextBoxColumn();
            ColSuperficie = new DataGridViewTextBoxColumn();
            ColAñoConstruccion = new DataGridViewTextBoxColumn();
            ColDescripcion = new DataGridViewTextBoxColumn();
            ColTipoInmueble = new DataGridViewTextBoxColumn();
            ColBarrio = new DataGridViewTextBoxColumn();
            ColDireccion = new DataGridViewTextBoxColumn();
            ColNroDireccion = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            lblResultados = new Label();
            lblClientes = new Label();
            lblGestionar = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvInmuebles).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvInmuebles
            // 
            dgvInmuebles.AllowUserToAddRows = false;
            dgvInmuebles.AllowUserToDeleteRows = false;
            dgvInmuebles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInmuebles.Columns.AddRange(new DataGridViewColumn[] { CodInmueble, ColSuperficie, ColAñoConstruccion, ColDescripcion, ColTipoInmueble, ColBarrio, ColDireccion, ColNroDireccion, ColPrecio });
            dgvInmuebles.Location = new Point(12, 147);
            dgvInmuebles.Name = "dgvInmuebles";
            dgvInmuebles.ReadOnly = true;
            dgvInmuebles.RowTemplate.Height = 25;
            dgvInmuebles.Size = new Size(1238, 500);
            dgvInmuebles.TabIndex = 95;
            // 
            // CodInmueble
            // 
            CodInmueble.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CodInmueble.HeaderText = "Inmueble";
            CodInmueble.Name = "CodInmueble";
            CodInmueble.ReadOnly = true;
            CodInmueble.Visible = false;
            // 
            // ColSuperficie
            // 
            ColSuperficie.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColSuperficie.HeaderText = "Superficie";
            ColSuperficie.Name = "ColSuperficie";
            ColSuperficie.ReadOnly = true;
            // 
            // ColAñoConstruccion
            // 
            ColAñoConstruccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColAñoConstruccion.HeaderText = "Año de Construcción";
            ColAñoConstruccion.Name = "ColAñoConstruccion";
            ColAñoConstruccion.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            ColDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDescripcion.HeaderText = "Descripción";
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.ReadOnly = true;
            // 
            // ColTipoInmueble
            // 
            ColTipoInmueble.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTipoInmueble.HeaderText = "Tipo de Inmueble";
            ColTipoInmueble.Name = "ColTipoInmueble";
            ColTipoInmueble.ReadOnly = true;
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
            // ColPrecio
            // 
            ColPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(934, 653);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 23);
            btnEliminar.TabIndex = 94;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1095, 653);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 23);
            btnEditar.TabIndex = 93;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 653);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 23);
            btnSalir.TabIndex = 91;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1097, 118);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(155, 23);
            btnAgregar.TabIndex = 90;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultados.Location = new Point(12, 119);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(102, 25);
            lblResultados.TabIndex = 89;
            lblResultados.Text = "Resultados";
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.BackColor = Color.Navy;
            lblClientes.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblClientes.ForeColor = Color.White;
            lblClientes.Location = new Point(12, 55);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(99, 25);
            lblClientes.TabIndex = 88;
            lblClientes.Text = "Inmuebles";
            // 
            // lblGestionar
            // 
            lblGestionar.AutoSize = true;
            lblGestionar.BackColor = Color.Navy;
            lblGestionar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblGestionar.ForeColor = Color.White;
            lblGestionar.Location = new Point(12, 30);
            lblGestionar.Name = "lblGestionar";
            lblGestionar.Size = new Size(118, 25);
            lblGestionar.TabIndex = 87;
            lblGestionar.Text = "GESTIONAR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 100);
            panel1.TabIndex = 92;
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
            // FrmSoporteInmueble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvInmuebles);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(lblResultados);
            Controls.Add(lblClientes);
            Controls.Add(lblGestionar);
            Controls.Add(panel1);
            Name = "FrmSoporteInmueble";
            Text = "FrmSoporteInmueble";
            Load += FrmSoporteInmueble_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInmuebles).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInmuebles;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnSalir;
        private Button btnAgregar;
        private Label lblResultados;
        private Label lblClientes;
        private Label lblGestionar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn CodInmueble;
        private DataGridViewTextBoxColumn ColSuperficie;
        private DataGridViewTextBoxColumn ColAñoConstruccion;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColTipoInmueble;
        private DataGridViewTextBoxColumn ColBarrio;
        private DataGridViewTextBoxColumn ColDireccion;
        private DataGridViewTextBoxColumn ColNroDireccion;
        private DataGridViewTextBoxColumn ColPrecio;
    }
}