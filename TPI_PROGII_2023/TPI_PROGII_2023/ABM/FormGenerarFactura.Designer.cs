namespace TPI_PROGII_2023
{
    partial class FormGenerarFactura
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
            lblInmobiliaria = new Label();
            lblFactura = new Label();
            lblTransaccion = new Label();
            lblAgenteInmobiliario = new Label();
            cboTransaccion = new ComboBox();
            cboAgente = new ComboBox();
            label1 = new Label();
            cboInmueble = new ComboBox();
            lblInmueble = new Label();
            cboCliente = new ComboBox();
            label3 = new Label();
            cboAlquiler = new ComboBox();
            lblAlquiler = new Label();
            lblPrecio = new Label();
            lblComision = new Label();
            numPrecio = new NumericUpDown();
            numComision = new NumericUpDown();
            dgvDetalle = new DataGridView();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblDetalle = new Label();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numComision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblInmobiliaria
            // 
            lblInmobiliaria.AutoSize = true;
            lblInmobiliaria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmobiliaria.Location = new Point(12, 11);
            lblInmobiliaria.Name = "lblInmobiliaria";
            lblInmobiliaria.Size = new Size(93, 21);
            lblInmobiliaria.TabIndex = 0;
            lblInmobiliaria.Text = "Inmobiliaria";
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFactura.Location = new Point(10, 65);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(141, 25);
            lblFactura.TabIndex = 1;
            lblFactura.Text = "FACTURA Nro:";
            // 
            // lblTransaccion
            // 
            lblTransaccion.AutoSize = true;
            lblTransaccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransaccion.Location = new Point(12, 98);
            lblTransaccion.Name = "lblTransaccion";
            lblTransaccion.Size = new Size(72, 15);
            lblTransaccion.TabIndex = 2;
            lblTransaccion.Text = "Transacción:";
            // 
            // lblAgenteInmobiliario
            // 
            lblAgenteInmobiliario.AutoSize = true;
            lblAgenteInmobiliario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgenteInmobiliario.Location = new Point(12, 146);
            lblAgenteInmobiliario.Name = "lblAgenteInmobiliario";
            lblAgenteInmobiliario.Size = new Size(115, 15);
            lblAgenteInmobiliario.TabIndex = 4;
            lblAgenteInmobiliario.Text = "Agente Inmobiliario:";
            // 
            // cboTransaccion
            // 
            cboTransaccion.FormattingEnabled = true;
            cboTransaccion.Location = new Point(12, 116);
            cboTransaccion.Name = "cboTransaccion";
            cboTransaccion.Size = new Size(660, 23);
            cboTransaccion.TabIndex = 6;
            cboTransaccion.SelectedIndexChanged += cboTransaccion_SelectedIndexChanged;
            // 
            // cboAgente
            // 
            cboAgente.FormattingEnabled = true;
            cboAgente.Location = new Point(12, 164);
            cboAgente.Name = "cboAgente";
            cboAgente.Size = new Size(320, 23);
            cboAgente.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(570, 13);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 8;
            label1.Text = "Fecha: 04/11/2023";
            // 
            // cboInmueble
            // 
            cboInmueble.FormattingEnabled = true;
            cboInmueble.Location = new Point(12, 253);
            cboInmueble.Name = "cboInmueble";
            cboInmueble.Size = new Size(660, 23);
            cboInmueble.TabIndex = 10;
            // 
            // lblInmueble
            // 
            lblInmueble.AutoSize = true;
            lblInmueble.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmueble.Location = new Point(12, 235);
            lblInmueble.Name = "lblInmueble";
            lblInmueble.Size = new Size(60, 15);
            lblInmueble.TabIndex = 9;
            lblInmueble.Text = "Inmueble:";
            // 
            // cboCliente
            // 
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(352, 164);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(320, 23);
            cboCliente.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(352, 146);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 11;
            label3.Text = "Cliente:";
            // 
            // cboAlquiler
            // 
            cboAlquiler.FormattingEnabled = true;
            cboAlquiler.Location = new Point(12, 253);
            cboAlquiler.Name = "cboAlquiler";
            cboAlquiler.Size = new Size(660, 23);
            cboAlquiler.TabIndex = 14;
            // 
            // lblAlquiler
            // 
            lblAlquiler.AutoSize = true;
            lblAlquiler.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlquiler.Location = new Point(12, 235);
            lblAlquiler.Name = "lblAlquiler";
            lblAlquiler.Size = new Size(51, 15);
            lblAlquiler.TabIndex = 13;
            lblAlquiler.Text = "Alquiler:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(12, 287);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio:";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblComision.Location = new Point(352, 287);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(101, 15);
            lblComision.TabIndex = 17;
            lblComision.Text = "Comision Cliente:";
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(12, 306);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(320, 23);
            numPrecio.TabIndex = 19;
            // 
            // numComision
            // 
            numComision.DecimalPlaces = 3;
            numComision.Location = new Point(352, 306);
            numComision.Name = "numComision";
            numComision.Size = new Size(320, 23);
            numComision.TabIndex = 20;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(12, 383);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowTemplate.Height = 25;
            dgvDetalle.Size = new Size(660, 424);
            dgvDetalle.TabIndex = 21;
            dgvDetalle.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 826);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(320, 23);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(352, 826);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(320, 23);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblDetalle
            // 
            lblDetalle.AutoSize = true;
            lblDetalle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDetalle.Location = new Point(10, 206);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(65, 21);
            lblDetalle.TabIndex = 24;
            lblDetalle.Text = "Detalle";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(352, 343);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(320, 23);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormGenerarFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 861);
            Controls.Add(btnAgregar);
            Controls.Add(lblDetalle);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(dgvDetalle);
            Controls.Add(numComision);
            Controls.Add(numPrecio);
            Controls.Add(lblComision);
            Controls.Add(lblPrecio);
            Controls.Add(cboAlquiler);
            Controls.Add(lblAlquiler);
            Controls.Add(cboCliente);
            Controls.Add(label3);
            Controls.Add(cboInmueble);
            Controls.Add(lblInmueble);
            Controls.Add(label1);
            Controls.Add(cboAgente);
            Controls.Add(cboTransaccion);
            Controls.Add(lblAgenteInmobiliario);
            Controls.Add(lblTransaccion);
            Controls.Add(lblFactura);
            Controls.Add(lblInmobiliaria);
            Name = "FormGenerarFactura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormGenerarFactura";
            Load += FormGenerarFactura_Load;
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numComision).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInmobiliaria;
        private Label lblFactura;
        private Label lblTransaccion;
        private Label lblAgenteInmobiliario;
        private ComboBox cboTransaccion;
        private ComboBox cboAgente;
        private Label label1;
        private ComboBox cboInmueble;
        private Label lblInmueble;
        private ComboBox cboCliente;
        private Label label3;
        private ComboBox cboAlquiler;
        private Label lblAlquiler;
        private Label lblPrecio;
        private Label lblComision;
        private NumericUpDown numPrecio;
        private NumericUpDown numComision;
        private DataGridView dgvDetalle;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblDetalle;
        private Button btnAgregar;
    }
}