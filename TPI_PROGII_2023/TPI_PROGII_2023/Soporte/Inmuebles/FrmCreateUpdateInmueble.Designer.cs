namespace InmobiliariaFront.Soporte.Inmuebles
{
    partial class FrmCreateUpdateInmueble
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
            btnGuardar = new Button();
            label1 = new Label();
            txtNroDireccion = new TextBox();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblSuperficie = new Label();
            lblInmueble = new Label();
            lblInmobiliaria = new Label();
            NumSuperficie = new NumericUpDown();
            NumAño = new NumericUpDown();
            lblAño = new Label();
            cboBarrio = new ComboBox();
            cboTipoInmueble = new ComboBox();
            label4 = new Label();
            lblTipoInmueble = new Label();
            numPrecio = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumSuperficie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumAño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(354, 399);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(318, 23);
            btnGuardar.TabIndex = 109;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(354, 241);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 108;
            label1.Text = "Nro. Direccion";
            // 
            // txtNroDireccion
            // 
            txtNroDireccion.Location = new Point(354, 259);
            txtNroDireccion.Name = "txtNroDireccion";
            txtNroDireccion.Size = new Size(318, 23);
            txtNroDireccion.TabIndex = 107;
            txtNroDireccion.TextChanged += txtNroDireccion_TextChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 259);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(320, 23);
            txtDireccion.TabIndex = 106;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(12, 241);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 105;
            lblDireccion.Text = "Direccion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(12, 162);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(660, 23);
            txtDescripcion.TabIndex = 94;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(12, 144);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(10, 15);
            lblDescripcion.TabIndex = 93;
            lblDescripcion.Text = " ";
            // 
            // lblSuperficie
            // 
            lblSuperficie.AutoSize = true;
            lblSuperficie.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuperficie.Location = new Point(12, 96);
            lblSuperficie.Name = "lblSuperficie";
            lblSuperficie.Size = new Size(59, 15);
            lblSuperficie.TabIndex = 92;
            lblSuperficie.Text = "Superficie";
            // 
            // lblInmueble
            // 
            lblInmueble.AutoSize = true;
            lblInmueble.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblInmueble.Location = new Point(10, 63);
            lblInmueble.Name = "lblInmueble";
            lblInmueble.Size = new Size(141, 25);
            lblInmueble.TabIndex = 90;
            lblInmueble.Text = "Inmueble Nro:";
            // 
            // lblInmobiliaria
            // 
            lblInmobiliaria.AutoSize = true;
            lblInmobiliaria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmobiliaria.Location = new Point(12, 9);
            lblInmobiliaria.Name = "lblInmobiliaria";
            lblInmobiliaria.Size = new Size(93, 21);
            lblInmobiliaria.TabIndex = 89;
            lblInmobiliaria.Text = "Inmobiliaria";
            // 
            // NumSuperficie
            // 
            NumSuperficie.DecimalPlaces = 2;
            NumSuperficie.Location = new Point(12, 114);
            NumSuperficie.Name = "NumSuperficie";
            NumSuperficie.Size = new Size(135, 23);
            NumSuperficie.TabIndex = 110;
            // 
            // NumAño
            // 
            NumAño.Location = new Point(187, 114);
            NumAño.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            NumAño.Minimum = new decimal(new int[] { 1910, 0, 0, 0 });
            NumAño.Name = "NumAño";
            NumAño.Size = new Size(135, 23);
            NumAño.TabIndex = 112;
            NumAño.Value = new decimal(new int[] { 1910, 0, 0, 0 });
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAño.Location = new Point(187, 96);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(119, 15);
            lblAño.TabIndex = 111;
            lblAño.Text = "Año de Construccion";
            // 
            // cboBarrio
            // 
            cboBarrio.FormattingEnabled = true;
            cboBarrio.Location = new Point(354, 214);
            cboBarrio.Name = "cboBarrio";
            cboBarrio.Size = new Size(318, 23);
            cboBarrio.TabIndex = 115;
            // 
            // cboTipoInmueble
            // 
            cboTipoInmueble.FormattingEnabled = true;
            cboTipoInmueble.Location = new Point(12, 214);
            cboTipoInmueble.Name = "cboTipoInmueble";
            cboTipoInmueble.Size = new Size(320, 23);
            cboTipoInmueble.TabIndex = 113;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(354, 195);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 117;
            label4.Text = "Barrio";
            // 
            // lblTipoInmueble
            // 
            lblTipoInmueble.AutoSize = true;
            lblTipoInmueble.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoInmueble.Location = new Point(12, 195);
            lblTipoInmueble.Name = "lblTipoInmueble";
            lblTipoInmueble.Size = new Size(99, 15);
            lblTipoInmueble.TabIndex = 118;
            lblTipoInmueble.Text = "Tipo de Inmueble";
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 3;
            numPrecio.Location = new Point(12, 318);
            numPrecio.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(135, 23);
            numPrecio.TabIndex = 120;
            numPrecio.Value = new decimal(new int[] { 1910, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 300);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 119;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 121;
            label3.Text = "Descripción";
            // 
            // FrmCreateUpdateInmueble
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(label3);
            Controls.Add(numPrecio);
            Controls.Add(label2);
            Controls.Add(lblTipoInmueble);
            Controls.Add(label4);
            Controls.Add(cboBarrio);
            Controls.Add(cboTipoInmueble);
            Controls.Add(NumAño);
            Controls.Add(lblAño);
            Controls.Add(NumSuperficie);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(txtNroDireccion);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblSuperficie);
            Controls.Add(lblInmueble);
            Controls.Add(lblInmobiliaria);
            Name = "FrmCreateUpdateInmueble";
            Text = "FrmCreateUpdateInmueble";
            FormClosed += FrmCreateUpdateInmueble_FormClosed;
            Load += FrmCreateUpdateInmueble_Load;
            ((System.ComponentModel.ISupportInitialize)NumSuperficie).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumAño).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label1;
        private TextBox txtNroDireccion;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Label lblSuperficie;
        private Label lblInmueble;
        private Label lblInmobiliaria;
        private NumericUpDown NumSuperficie;
        private NumericUpDown NumAño;
        private Label lblAño;
        private ComboBox cboBarrio;
        private ComboBox cboTipoInmueble;
        private Label label4;
        private Label lblTipoInmueble;
        private NumericUpDown numPrecio;
        private Label label2;
        private Label label3;
    }
}