namespace InmobiliariaFront.Reportes
{
    partial class FrmConsultarInmueblesDisponibles
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtLocalidad = new TextBox();
            lblLocalidad = new Label();
            numPrecioHasta = new NumericUpDown();
            lblPrecioHasta = new Label();
            numPrecioDesde = new NumericUpDown();
            btnSalir = new Button();
            btnConsultar = new Button();
            lblResultados = new Label();
            lblPrecioDesde = new Label();
            lblInmueblesDisponibles = new Label();
            lblFactura = new Label();
            dgvInmueblesDisponibles = new DataGridView();
            ColLocalidad = new DataGridViewTextBoxColumn();
            ColBarrio = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ColDireccion = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColTransaccion = new DataGridViewTextBoxColumn();
            txtBarrio = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numPrecioHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInmueblesDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(12, 113);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(305, 23);
            txtLocalidad.TabIndex = 41;
            txtLocalidad.TextChanged += txtLocalidad_TextChanged;
            // 
            // lblLocalidad
            // 
            lblLocalidad.AutoSize = true;
            lblLocalidad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLocalidad.Location = new Point(12, 95);
            lblLocalidad.Name = "lblLocalidad";
            lblLocalidad.Size = new Size(58, 15);
            lblLocalidad.TabIndex = 40;
            lblLocalidad.Text = "Localidad";
            // 
            // numPrecioHasta
            // 
            numPrecioHasta.Location = new Point(947, 113);
            numPrecioHasta.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecioHasta.Name = "numPrecioHasta";
            numPrecioHasta.Size = new Size(305, 23);
            numPrecioHasta.TabIndex = 39;
            // 
            // lblPrecioHasta
            // 
            lblPrecioHasta.AutoSize = true;
            lblPrecioHasta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioHasta.Location = new Point(947, 95);
            lblPrecioHasta.Name = "lblPrecioHasta";
            lblPrecioHasta.Size = new Size(71, 15);
            lblPrecioHasta.TabIndex = 38;
            lblPrecioHasta.Text = "Precio hasta";
            // 
            // numPrecioDesde
            // 
            numPrecioDesde.Location = new Point(636, 114);
            numPrecioDesde.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecioDesde.Name = "numPrecioDesde";
            numPrecioDesde.Size = new Size(305, 23);
            numPrecioDesde.TabIndex = 37;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1097, 647);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 23);
            btnSalir.TabIndex = 36;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(1097, 163);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(155, 23);
            btnConsultar.TabIndex = 35;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultados.Location = new Point(12, 164);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(102, 25);
            lblResultados.TabIndex = 33;
            lblResultados.Text = "Resultados";
            // 
            // lblPrecioDesde
            // 
            lblPrecioDesde.AutoSize = true;
            lblPrecioDesde.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioDesde.Location = new Point(636, 96);
            lblPrecioDesde.Name = "lblPrecioDesde";
            lblPrecioDesde.Size = new Size(74, 15);
            lblPrecioDesde.TabIndex = 32;
            lblPrecioDesde.Text = "Precio desde";
            // 
            // lblInmueblesDisponibles
            // 
            lblInmueblesDisponibles.AutoSize = true;
            lblInmueblesDisponibles.BackColor = Color.Navy;
            lblInmueblesDisponibles.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmueblesDisponibles.ForeColor = Color.White;
            lblInmueblesDisponibles.Location = new Point(12, 35);
            lblInmueblesDisponibles.Name = "lblInmueblesDisponibles";
            lblInmueblesDisponibles.Size = new Size(202, 25);
            lblInmueblesDisponibles.TabIndex = 31;
            lblInmueblesDisponibles.Text = "Inmuebles Disponibles";
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.BackColor = Color.Navy;
            lblFactura.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFactura.ForeColor = Color.White;
            lblFactura.Location = new Point(12, 10);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(122, 25);
            lblFactura.TabIndex = 30;
            lblFactura.Text = "CONSULTAR";
            // 
            // dgvInmueblesDisponibles
            // 
            dgvInmueblesDisponibles.AllowUserToAddRows = false;
            dgvInmueblesDisponibles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInmueblesDisponibles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInmueblesDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInmueblesDisponibles.Columns.AddRange(new DataGridViewColumn[] { ColLocalidad, ColBarrio, dataGridViewTextBoxColumn1, ColDireccion, ColPrecio, ColTransaccion });
            dgvInmueblesDisponibles.Location = new Point(12, 192);
            dgvInmueblesDisponibles.Name = "dgvInmueblesDisponibles";
            dgvInmueblesDisponibles.ReadOnly = true;
            dgvInmueblesDisponibles.RowTemplate.Height = 25;
            dgvInmueblesDisponibles.Size = new Size(1240, 449);
            dgvInmueblesDisponibles.TabIndex = 42;
            // 
            // ColLocalidad
            // 
            ColLocalidad.HeaderText = "Localidad";
            ColLocalidad.Name = "ColLocalidad";
            ColLocalidad.ReadOnly = true;
            ColLocalidad.Width = 250;
            // 
            // ColBarrio
            // 
            ColBarrio.HeaderText = "Barrio";
            ColBarrio.Name = "ColBarrio";
            ColBarrio.ReadOnly = true;
            ColBarrio.Width = 250;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Inmueble";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // ColDireccion
            // 
            ColDireccion.HeaderText = "Direccion";
            ColDireccion.Name = "ColDireccion";
            ColDireccion.ReadOnly = true;
            ColDireccion.Width = 200;
            // 
            // ColPrecio
            // 
            ColPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPrecio.HeaderText = "Precio";
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            // 
            // ColTransaccion
            // 
            ColTransaccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTransaccion.HeaderText = "Transaccion";
            ColTransaccion.Name = "ColTransaccion";
            ColTransaccion.ReadOnly = true;
            // 
            // txtBarrio
            // 
            txtBarrio.Location = new Point(323, 114);
            txtBarrio.Name = "txtBarrio";
            txtBarrio.Size = new Size(305, 23);
            txtBarrio.TabIndex = 44;
            txtBarrio.TextChanged += txtBarrio_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(323, 96);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 43;
            label1.Text = "Barrio";
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
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-7, -17);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 100);
            panel1.TabIndex = 45;
            // 
            // FrmConsultarInmueblesDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(txtBarrio);
            Controls.Add(label1);
            Controls.Add(dgvInmueblesDisponibles);
            Controls.Add(txtLocalidad);
            Controls.Add(lblLocalidad);
            Controls.Add(numPrecioHasta);
            Controls.Add(lblPrecioHasta);
            Controls.Add(numPrecioDesde);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(lblResultados);
            Controls.Add(lblPrecioDesde);
            Controls.Add(lblInmueblesDisponibles);
            Controls.Add(lblFactura);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmConsultarInmueblesDisponibles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarInmueblesDisponibles";
            Load += FrmConsultarInmueblesDisponibles_Load;
            ((System.ComponentModel.ISupportInitialize)numPrecioHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInmueblesDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLocalidad;
        private Label lblLocalidad;
        private NumericUpDown numPrecioHasta;
        private Label lblPrecioHasta;
        private NumericUpDown numPrecioDesde;
        private Button btnSalir;
        private Button btnConsultar;
        private Label lblResultados;
        private Label lblPrecioDesde;
        private Label lblInmueblesDisponibles;
        private Label lblFactura;
        private DataGridView dgvInmueblesDisponibles;
        private DataGridViewTextBoxColumn ColLocalidad;
        private DataGridViewTextBoxColumn ColBarrio;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ColDireccion;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColTransaccion;
        private TextBox txtBarrio;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}