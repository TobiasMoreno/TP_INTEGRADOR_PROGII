namespace InmobiliariaFront.Reportes
{
    partial class FrmConsultarClientesCumplidores
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
            dtpHasta = new DateTimePicker();
            lblHasta = new Label();
            dtpDesde = new DateTimePicker();
            numDia = new NumericUpDown();
            lblPagoAnte = new Label();
            btnSalir = new Button();
            btnConsultar = new Button();
            dgvInquilinosCumplidores = new DataGridView();
            ColCliente = new DataGridViewTextBoxColumn();
            ColInmueble = new DataGridViewTextBoxColumn();
            ColBarrio = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            lblResultados = new Label();
            lblDesde = new Label();
            lblInquilinosDeudores = new Label();
            lblFactura = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numDia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInquilinosCumplidores).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(323, 113);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(305, 23);
            dtpHasta.TabIndex = 37;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasta.Location = new Point(323, 95);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(37, 15);
            lblHasta.TabIndex = 36;
            lblHasta.Text = "Hasta";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(12, 113);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(305, 23);
            dtpDesde.TabIndex = 35;
            // 
            // numDia
            // 
            numDia.Location = new Point(634, 113);
            numDia.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numDia.Name = "numDia";
            numDia.Size = new Size(305, 23);
            numDia.TabIndex = 34;
            // 
            // lblPagoAnte
            // 
            lblPagoAnte.AutoSize = true;
            lblPagoAnte.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagoAnte.Location = new Point(634, 95);
            lblPagoAnte.Name = "lblPagoAnte";
            lblPagoAnte.Size = new Size(112, 15);
            lblPagoAnte.TabIndex = 33;
            lblPagoAnte.Text = "Abonó antes del dia";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1097, 646);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 23);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(1097, 162);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(155, 23);
            btnConsultar.TabIndex = 30;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvInquilinosCumplidores
            // 
            dgvInquilinosCumplidores.AllowUserToAddRows = false;
            dgvInquilinosCumplidores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInquilinosCumplidores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInquilinosCumplidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInquilinosCumplidores.Columns.AddRange(new DataGridViewColumn[] { ColCliente, ColInmueble, ColBarrio, colDireccion });
            dgvInquilinosCumplidores.Location = new Point(12, 191);
            dgvInquilinosCumplidores.Name = "dgvInquilinosCumplidores";
            dgvInquilinosCumplidores.ReadOnly = true;
            dgvInquilinosCumplidores.RowTemplate.Height = 25;
            dgvInquilinosCumplidores.Size = new Size(1240, 449);
            dgvInquilinosCumplidores.TabIndex = 29;
            // 
            // ColCliente
            // 
            ColCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            // 
            // ColInmueble
            // 
            ColInmueble.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColInmueble.HeaderText = "Inmueble alquilado";
            ColInmueble.Name = "ColInmueble";
            ColInmueble.ReadOnly = true;
            // 
            // ColBarrio
            // 
            ColBarrio.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColBarrio.HeaderText = "Barrio";
            ColBarrio.Name = "ColBarrio";
            ColBarrio.ReadOnly = true;
            // 
            // colDireccion
            // 
            colDireccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDireccion.HeaderText = "Direccion";
            colDireccion.Name = "colDireccion";
            colDireccion.ReadOnly = true;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultados.Location = new Point(12, 163);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(102, 25);
            lblResultados.TabIndex = 28;
            lblResultados.Text = "Resultados";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesde.Location = new Point(12, 95);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(39, 15);
            lblDesde.TabIndex = 27;
            lblDesde.Text = "Desde";
            // 
            // lblInquilinosDeudores
            // 
            lblInquilinosDeudores.AutoSize = true;
            lblInquilinosDeudores.BackColor = Color.Navy;
            lblInquilinosDeudores.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInquilinosDeudores.ForeColor = Color.White;
            lblInquilinosDeudores.Location = new Point(12, 34);
            lblInquilinosDeudores.Name = "lblInquilinosDeudores";
            lblInquilinosDeudores.Size = new Size(191, 25);
            lblInquilinosDeudores.TabIndex = 26;
            lblInquilinosDeudores.Text = "Clientes Cumplidores";
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.BackColor = Color.Navy;
            lblFactura.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFactura.ForeColor = Color.White;
            lblFactura.Location = new Point(12, 9);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(122, 25);
            lblFactura.TabIndex = 25;
            lblFactura.Text = "CONSULTAR";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-9, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 100);
            panel1.TabIndex = 32;
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
            // FrmConsultarClientesCumplidores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dtpHasta);
            Controls.Add(lblHasta);
            Controls.Add(dtpDesde);
            Controls.Add(numDia);
            Controls.Add(lblPagoAnte);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(dgvInquilinosCumplidores);
            Controls.Add(lblResultados);
            Controls.Add(lblDesde);
            Controls.Add(lblInquilinosDeudores);
            Controls.Add(lblFactura);
            Controls.Add(panel1);
            Name = "FrmConsultarClientesCumplidores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarClientesCumplidores";
            ((System.ComponentModel.ISupportInitialize)numDia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInquilinosCumplidores).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHasta;
        private Label lblHasta;
        private DateTimePicker dtpDesde;
        private NumericUpDown numDia;
        private Label lblPagoAnte;
        private Button btnSalir;
        private Button btnConsultar;
        private DataGridView dgvInquilinosCumplidores;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColInmueble;
        private DataGridViewTextBoxColumn ColBarrio;
        private DataGridViewTextBoxColumn colDireccion;
        private Label lblResultados;
        private Label lblDesde;
        private Label lblInquilinosDeudores;
        private Label lblFactura;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}