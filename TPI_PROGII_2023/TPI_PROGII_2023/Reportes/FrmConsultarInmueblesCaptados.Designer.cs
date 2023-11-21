namespace InmobiliariaFront.Reportes
{
    partial class FrmConsultarInmueblesCaptados
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
            numAñoDesde = new NumericUpDown();
            btnSalir = new Button();
            btnConsultar = new Button();
            lblResultados = new Label();
            lblAñoDesde = new Label();
            lblInmueblesCaptados = new Label();
            lblFactura = new Label();
            numAñoHasta = new NumericUpDown();
            lblAñoHasta = new Label();
            lblAgenteInmobiliario = new Label();
            txtAgenteInmobiliario = new TextBox();
            dgvInmueblesCaptados = new DataGridView();
            ColInmueble = new DataGridViewTextBoxColumn();
            ColAgenteInmobiliario = new DataGridViewTextBoxColumn();
            ColCliente = new DataGridViewTextBoxColumn();
            ColAño = new DataGridViewTextBoxColumn();
            ColNroFactura = new DataGridViewTextBoxColumn();
            ColCostoVenta = new DataGridViewTextBoxColumn();
            ColComisionContrato = new DataGridViewTextBoxColumn();
            ColComisionCliente = new DataGridViewTextBoxColumn();
            ColTotalGanancia = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numAñoDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAñoHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInmueblesCaptados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // numAñoDesde
            // 
            numAñoDesde.Location = new Point(12, 114);
            numAñoDesde.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numAñoDesde.Name = "numAñoDesde";
            numAñoDesde.Size = new Size(305, 23);
            numAñoDesde.TabIndex = 24;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1097, 647);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 23);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(1097, 163);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(155, 23);
            btnConsultar.TabIndex = 22;
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
            lblResultados.TabIndex = 20;
            lblResultados.Text = "Resultados";
            // 
            // lblAñoDesde
            // 
            lblAñoDesde.AutoSize = true;
            lblAñoDesde.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAñoDesde.Location = new Point(12, 96);
            lblAñoDesde.Name = "lblAñoDesde";
            lblAñoDesde.Size = new Size(63, 15);
            lblAñoDesde.TabIndex = 19;
            lblAñoDesde.Text = "Año desde";
            // 
            // lblInmueblesCaptados
            // 
            lblInmueblesCaptados.AutoSize = true;
            lblInmueblesCaptados.BackColor = Color.Navy;
            lblInmueblesCaptados.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmueblesCaptados.ForeColor = Color.White;
            lblInmueblesCaptados.Location = new Point(12, 35);
            lblInmueblesCaptados.Name = "lblInmueblesCaptados";
            lblInmueblesCaptados.Size = new Size(183, 25);
            lblInmueblesCaptados.TabIndex = 18;
            lblInmueblesCaptados.Text = "Inmuebles Captados";
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
            lblFactura.TabIndex = 17;
            lblFactura.Text = "CONSULTAR";
            // 
            // numAñoHasta
            // 
            numAñoHasta.Location = new Point(323, 114);
            numAñoHasta.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numAñoHasta.Name = "numAñoHasta";
            numAñoHasta.Size = new Size(305, 23);
            numAñoHasta.TabIndex = 26;
            // 
            // lblAñoHasta
            // 
            lblAñoHasta.AutoSize = true;
            lblAñoHasta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAñoHasta.Location = new Point(323, 96);
            lblAñoHasta.Name = "lblAñoHasta";
            lblAñoHasta.Size = new Size(60, 15);
            lblAñoHasta.TabIndex = 25;
            lblAñoHasta.Text = "Año hasta";
            // 
            // lblAgenteInmobiliario
            // 
            lblAgenteInmobiliario.AutoSize = true;
            lblAgenteInmobiliario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAgenteInmobiliario.Location = new Point(634, 96);
            lblAgenteInmobiliario.Name = "lblAgenteInmobiliario";
            lblAgenteInmobiliario.Size = new Size(112, 15);
            lblAgenteInmobiliario.TabIndex = 27;
            lblAgenteInmobiliario.Text = "Agente inmobiliario";
            // 
            // txtAgenteInmobiliario
            // 
            txtAgenteInmobiliario.Location = new Point(634, 114);
            txtAgenteInmobiliario.Name = "txtAgenteInmobiliario";
            txtAgenteInmobiliario.Size = new Size(305, 23);
            txtAgenteInmobiliario.TabIndex = 29;
            txtAgenteInmobiliario.TextChanged += txtAgenteInmobiliario_TextChanged;
            // 
            // dgvInmueblesCaptados
            // 
            dgvInmueblesCaptados.AllowUserToAddRows = false;
            dgvInmueblesCaptados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInmueblesCaptados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInmueblesCaptados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInmueblesCaptados.Columns.AddRange(new DataGridViewColumn[] { ColInmueble, ColAgenteInmobiliario, ColCliente, ColAño, ColNroFactura, ColCostoVenta, ColComisionContrato, ColComisionCliente, ColTotalGanancia });
            dgvInmueblesCaptados.Location = new Point(12, 192);
            dgvInmueblesCaptados.Name = "dgvInmueblesCaptados";
            dgvInmueblesCaptados.ReadOnly = true;
            dgvInmueblesCaptados.RowTemplate.Height = 25;
            dgvInmueblesCaptados.Size = new Size(1240, 449);
            dgvInmueblesCaptados.TabIndex = 35;
            // 
            // ColInmueble
            // 
            ColInmueble.HeaderText = "Inmueble";
            ColInmueble.Name = "ColInmueble";
            ColInmueble.ReadOnly = true;
            ColInmueble.Width = 150;
            // 
            // ColAgenteInmobiliario
            // 
            ColAgenteInmobiliario.HeaderText = "Agente Inmobiliario";
            ColAgenteInmobiliario.Name = "ColAgenteInmobiliario";
            ColAgenteInmobiliario.ReadOnly = true;
            ColAgenteInmobiliario.Width = 150;
            // 
            // ColCliente
            // 
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            ColCliente.Width = 150;
            // 
            // ColAño
            // 
            ColAño.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColAño.HeaderText = "Año";
            ColAño.Name = "ColAño";
            ColAño.ReadOnly = true;
            // 
            // ColNroFactura
            // 
            ColNroFactura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNroFactura.HeaderText = "Nro. Factura";
            ColNroFactura.Name = "ColNroFactura";
            ColNroFactura.ReadOnly = true;
            // 
            // ColCostoVenta
            // 
            ColCostoVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCostoVenta.HeaderText = "Costo de venta";
            ColCostoVenta.Name = "ColCostoVenta";
            ColCostoVenta.ReadOnly = true;
            // 
            // ColComisionContrato
            // 
            ColComisionContrato.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColComisionContrato.HeaderText = "Comision por contrato";
            ColComisionContrato.Name = "ColComisionContrato";
            ColComisionContrato.ReadOnly = true;
            // 
            // ColComisionCliente
            // 
            ColComisionCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColComisionCliente.HeaderText = "Comision por parte del Cliente";
            ColComisionCliente.Name = "ColComisionCliente";
            ColComisionCliente.ReadOnly = true;
            // 
            // ColTotalGanancia
            // 
            ColTotalGanancia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTotalGanancia.HeaderText = "Total de Ganancia";
            ColTotalGanancia.Name = "ColTotalGanancia";
            ColTotalGanancia.ReadOnly = true;
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
            panel1.Location = new Point(-7, -21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 100);
            panel1.TabIndex = 36;
            // 
            // FrmConsultarInmueblesCaptados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvInmueblesCaptados);
            Controls.Add(txtAgenteInmobiliario);
            Controls.Add(lblAgenteInmobiliario);
            Controls.Add(numAñoHasta);
            Controls.Add(lblAñoHasta);
            Controls.Add(numAñoDesde);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(lblResultados);
            Controls.Add(lblAñoDesde);
            Controls.Add(lblInmueblesCaptados);
            Controls.Add(lblFactura);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmConsultarInmueblesCaptados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarInmueblesCaptados";
            Load += FrmConsultarInmueblesCaptados_Load;
            ((System.ComponentModel.ISupportInitialize)numAñoDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAñoHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInmueblesCaptados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numAñoDesde;
        private Button btnSalir;
        private Button btnConsultar;
        private Label lblResultados;
        private Label lblAñoDesde;
        private Label lblInmueblesCaptados;
        private Label lblFactura;
        private NumericUpDown numAñoHasta;
        private Label lblAñoHasta;
        private Label lblAgenteInmobiliario;
        private TextBox txtAgenteInmobiliario;
        private DataGridView dgvInmueblesCaptados;
        private DataGridViewTextBoxColumn ColInmueble;
        private DataGridViewTextBoxColumn ColAgenteInmobiliario;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColAño;
        private DataGridViewTextBoxColumn ColNroFactura;
        private DataGridViewTextBoxColumn ColCostoVenta;
        private DataGridViewTextBoxColumn ColComisionContrato;
        private DataGridViewTextBoxColumn ColComisionCliente;
        private DataGridViewTextBoxColumn ColTotalGanancia;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}