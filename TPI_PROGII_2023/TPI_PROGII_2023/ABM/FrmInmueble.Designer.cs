namespace InmobiliariaFront.ABM
{
    partial class FrmInmueble
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
            panel1 = new Panel();
            lblInmueble = new Label();
            lblInmobiliaria = new Label();
            pictureBox1 = new PictureBox();
            lblBarrio = new Label();
            cboTipoInmueble = new ComboBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            dgvInmuebles = new DataGridView();
            CodInmueble = new DataGridViewTextBoxColumn();
            ColSuperficie = new DataGridViewTextBoxColumn();
            ColAñoconstruccion = new DataGridViewTextBoxColumn();
            ColDescripcion = new DataGridViewTextBoxColumn();
            ColTipoInmueble = new DataGridViewTextBoxColumn();
            ColBarrio = new DataGridViewTextBoxColumn();
            ColDireccion = new DataGridViewTextBoxColumn();
            ColNroDireccion = new DataGridViewTextBoxColumn();
            ColContratoInterm = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            BtnModificar = new DataGridViewButtonColumn();
            NumSuperficie = new NumericUpDown();
            NumAñoConstruccion = new NumericUpDown();
            lblAñoConstruccion = new Label();
            label2 = new Label();
            cboBarrio = new ComboBox();
            lblNroDireccion = new Label();
            txtNroDireccion = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            NumContrato = new NumericUpDown();
            lblContratoIntermediacion = new Label();
            NumPrecio = new NumericUpDown();
            lblPrecio = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInmuebles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumSuperficie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumAñoConstruccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumContrato).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumPrecio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(lblInmueble);
            panel1.Controls.Add(lblInmobiliaria);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 91);
            panel1.TabIndex = 51;
            // 
            // lblInmueble
            // 
            lblInmueble.AutoSize = true;
            lblInmueble.BackColor = Color.Navy;
            lblInmueble.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmueble.ForeColor = Color.White;
            lblInmueble.Location = new Point(13, 44);
            lblInmueble.Name = "lblInmueble";
            lblInmueble.Size = new Size(99, 25);
            lblInmueble.TabIndex = 49;
            lblInmueble.Text = "Inmuebles";
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Navy;
            pictureBox1.Image = Properties.Resources.Texto;
            pictureBox1.Location = new Point(964, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblBarrio
            // 
            lblBarrio.AutoSize = true;
            lblBarrio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBarrio.Location = new Point(15, 184);
            lblBarrio.Name = "lblBarrio";
            lblBarrio.Size = new Size(130, 21);
            lblBarrio.TabIndex = 69;
            lblBarrio.Text = "Tipo de Inmueble";
            // 
            // cboTipoInmueble
            // 
            cboTipoInmueble.FormattingEnabled = true;
            cboTipoInmueble.Location = new Point(15, 208);
            cboTipoInmueble.Name = "cboTipoInmueble";
            cboTipoInmueble.Size = new Size(226, 23);
            cboTipoInmueble.TabIndex = 68;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 114);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(79, 21);
            lblNombre.TabIndex = 59;
            lblNombre.Text = "Superficie";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(592, 114);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(91, 21);
            lblDescripcion.TabIndex = 58;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(595, 138);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(320, 23);
            txtDescripcion.TabIndex = 57;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(964, 812);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(320, 23);
            btnGuardar.TabIndex = 55;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(15, 812);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(320, 23);
            btnSalir.TabIndex = 54;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(964, 330);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(320, 23);
            btnAgregar.TabIndex = 53;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvInmuebles
            // 
            dgvInmuebles.AllowUserToDeleteRows = false;
            dgvInmuebles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInmuebles.Columns.AddRange(new DataGridViewColumn[] { CodInmueble, ColSuperficie, ColAñoconstruccion, ColDescripcion, ColTipoInmueble, ColBarrio, ColDireccion, ColNroDireccion, ColContratoInterm, ColPrecio, BtnModificar });
            dgvInmuebles.Location = new Point(15, 369);
            dgvInmuebles.Name = "dgvInmuebles";
            dgvInmuebles.ReadOnly = true;
            dgvInmuebles.RowTemplate.Height = 25;
            dgvInmuebles.Size = new Size(1269, 424);
            dgvInmuebles.TabIndex = 52;
            // 
            // CodInmueble
            // 
            CodInmueble.HeaderText = "";
            CodInmueble.Name = "CodInmueble";
            CodInmueble.ReadOnly = true;
            CodInmueble.Width = 50;
            // 
            // ColSuperficie
            // 
            ColSuperficie.HeaderText = "Superficie";
            ColSuperficie.Name = "ColSuperficie";
            ColSuperficie.ReadOnly = true;
            // 
            // ColAñoconstruccion
            // 
            ColAñoconstruccion.HeaderText = "Año de Construcción";
            ColAñoconstruccion.Name = "ColAñoconstruccion";
            ColAñoconstruccion.ReadOnly = true;
            // 
            // ColDescripcion
            // 
            ColDescripcion.HeaderText = "Descripción";
            ColDescripcion.Name = "ColDescripcion";
            ColDescripcion.ReadOnly = true;
            // 
            // ColTipoInmueble
            // 
            ColTipoInmueble.HeaderText = "Tipo de Inmueble";
            ColTipoInmueble.Name = "ColTipoInmueble";
            ColTipoInmueble.ReadOnly = true;
            // 
            // ColBarrio
            // 
            ColBarrio.HeaderText = "Barrio";
            ColBarrio.Name = "ColBarrio";
            ColBarrio.ReadOnly = true;
            // 
            // ColDireccion
            // 
            ColDireccion.HeaderText = "Direccion";
            ColDireccion.Name = "ColDireccion";
            ColDireccion.ReadOnly = true;
            // 
            // ColNroDireccion
            // 
            ColNroDireccion.HeaderText = "N°Direccion";
            ColNroDireccion.Name = "ColNroDireccion";
            ColNroDireccion.ReadOnly = true;
            // 
            // ColContratoInterm
            // 
            ColContratoInterm.HeaderText = "Contrato de Intermediacion";
            ColContratoInterm.Name = "ColContratoInterm";
            ColContratoInterm.ReadOnly = true;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // BtnModificar
            // 
            BtnModificar.HeaderText = "Modificar";
            BtnModificar.Name = "BtnModificar";
            BtnModificar.ReadOnly = true;
            // 
            // NumSuperficie
            // 
            NumSuperficie.Location = new Point(15, 139);
            NumSuperficie.Name = "NumSuperficie";
            NumSuperficie.Size = new Size(226, 23);
            NumSuperficie.TabIndex = 74;
            // 
            // NumAñoConstruccion
            // 
            NumAñoConstruccion.Location = new Point(291, 139);
            NumAñoConstruccion.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            NumAñoConstruccion.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            NumAñoConstruccion.Name = "NumAñoConstruccion";
            NumAñoConstruccion.Size = new Size(237, 23);
            NumAñoConstruccion.TabIndex = 75;
            NumAñoConstruccion.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // lblAñoConstruccion
            // 
            lblAñoConstruccion.AutoSize = true;
            lblAñoConstruccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAñoConstruccion.Location = new Point(291, 115);
            lblAñoConstruccion.Name = "lblAñoConstruccion";
            lblAñoConstruccion.Size = new Size(154, 21);
            lblAñoConstruccion.TabIndex = 76;
            lblAñoConstruccion.Text = "Año de Construcción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(291, 184);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 78;
            label2.Text = "Barrio";
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(291, 208);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(237, 23);
            cboBarrio.TabIndex = 77;
            // 
            // lblNroDireccion
            // 
            lblNroDireccion.AutoSize = true;
            lblNroDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNroDireccion.Location = new Point(17, 261);
            lblNroDireccion.Name = "lblNroDireccion";
            lblNroDireccion.Size = new Size(97, 21);
            lblNroDireccion.TabIndex = 82;
            lblNroDireccion.Text = "N° Direccion";
            // 
            // txtNroDireccion
            // 
            txtNroDireccion.Location = new Point(17, 285);
            txtNroDireccion.Name = "txtNroDireccion";
            txtNroDireccion.Size = new Size(224, 23);
            txtNroDireccion.TabIndex = 81;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(592, 183);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 21);
            lblDireccion.TabIndex = 80;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(595, 207);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(320, 23);
            txtDireccion.TabIndex = 79;
            // 
            // NumContrato
            // 
            NumContrato.Location = new Point(292, 286);
            NumContrato.Name = "NumContrato";
            NumContrato.Size = new Size(236, 23);
            NumContrato.TabIndex = 84;
            // 
            // lblContratoIntermediacion
            // 
            lblContratoIntermediacion.AutoSize = true;
            lblContratoIntermediacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContratoIntermediacion.Location = new Point(289, 261);
            lblContratoIntermediacion.Name = "lblContratoIntermediacion";
            lblContratoIntermediacion.Size = new Size(179, 21);
            lblContratoIntermediacion.TabIndex = 83;
            lblContratoIntermediacion.Text = "Contrato Intermediacion";
            // 
            // NumPrecio
            // 
            NumPrecio.DecimalPlaces = 3;
            NumPrecio.Location = new Point(595, 285);
            NumPrecio.Name = "NumPrecio";
            NumPrecio.Size = new Size(320, 23);
            NumPrecio.TabIndex = 86;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(592, 260);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 21);
            lblPrecio.TabIndex = 85;
            lblPrecio.Text = "Precio";
            // 
            // button1
            // 
            button1.Location = new Point(481, 812);
            button1.Name = "button1";
            button1.Size = new Size(320, 23);
            button1.TabIndex = 87;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmInmueble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 861);
            Controls.Add(button1);
            Controls.Add(NumPrecio);
            Controls.Add(pictureBox1);
            Controls.Add(lblPrecio);
            Controls.Add(NumContrato);
            Controls.Add(lblContratoIntermediacion);
            Controls.Add(lblNroDireccion);
            Controls.Add(txtNroDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(cboBarrio);
            Controls.Add(lblAñoConstruccion);
            Controls.Add(NumAñoConstruccion);
            Controls.Add(NumSuperficie);
            Controls.Add(lblBarrio);
            Controls.Add(cboTipoInmueble);
            Controls.Add(lblNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(btnGuardar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(dgvInmuebles);
            Controls.Add(panel1);
            Name = "FrmInmueble";
            Text = "FrmInmueble";
            Load += FrmInmueble_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInmuebles).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumSuperficie).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumAñoConstruccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumContrato).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblInmueble;
        private PictureBox pictureBox1;
        private Label lblInmobiliaria;
        private Label label1;
        private Label lblBarrio;
        private ComboBox cboTipoInmueble;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnSalir;
        private Button btnAgregar;
        private DataGridView dgvInmuebles;
        private NumericUpDown NumSuperficie;
        private NumericUpDown NumAñoConstruccion;
        private Label lblAñoConstruccion;
        private Label label2;
        private ComboBox cboBarrio;
        private Label lblNroDireccion;
        private TextBox txtNroDireccion;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private NumericUpDown NumContrato;
        private Label lblContratoIntermediacion;
        private NumericUpDown NumPrecio;
        private Label lblPrecio;
        private Button button1;
        private DataGridViewTextBoxColumn CodInmueble;
        private DataGridViewTextBoxColumn ColSuperficie;
        private DataGridViewTextBoxColumn ColAñoconstruccion;
        private DataGridViewTextBoxColumn ColDescripcion;
        private DataGridViewTextBoxColumn ColTipoInmueble;
        private DataGridViewTextBoxColumn ColBarrio;
        private DataGridViewTextBoxColumn ColDireccion;
        private DataGridViewTextBoxColumn ColNroDireccion;
        private DataGridViewTextBoxColumn ColContratoInterm;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewButtonColumn BtnModificar;
        private Button button2;
    }
}