namespace InmobiliariaFront.Reportes
{
    partial class FrmConsultarClientesDeudores
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
            lblFactura = new Label();
            lblInquilinosDeudores = new Label();
            lblMinimoCantImpagas = new Label();
            lblResultados = new Label();
            dgvInquilinosDeudores = new DataGridView();
            ColCliente = new DataGridViewTextBoxColumn();
            ColNroAlquiler = new DataGridViewTextBoxColumn();
            ColInmueble = new DataGridViewTextBoxColumn();
            ColFechaInicio = new DataGridViewTextBoxColumn();
            ColMesesAlquiler = new DataGridViewTextBoxColumn();
            ColCantidadFacturasPagas = new DataGridViewTextBoxColumn();
            ColCantidadFacturasImpagas = new DataGridViewTextBoxColumn();
            btnConsultar = new Button();
            btnSalir = new Button();
            numCantImpagas = new NumericUpDown();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvInquilinosDeudores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantImpagas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            lblFactura.TabIndex = 2;
            lblFactura.Text = "CONSULTAR";
            // 
            // lblInquilinosDeudores
            // 
            lblInquilinosDeudores.AutoSize = true;
            lblInquilinosDeudores.BackColor = Color.Navy;
            lblInquilinosDeudores.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInquilinosDeudores.ForeColor = Color.White;
            lblInquilinosDeudores.Location = new Point(12, 34);
            lblInquilinosDeudores.Name = "lblInquilinosDeudores";
            lblInquilinosDeudores.Size = new Size(181, 25);
            lblInquilinosDeudores.TabIndex = 3;
            lblInquilinosDeudores.Text = "Inquilinos Deudores";
            // 
            // lblMinimoCantImpagas
            // 
            lblMinimoCantImpagas.AutoSize = true;
            lblMinimoCantImpagas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMinimoCantImpagas.Location = new Point(12, 95);
            lblMinimoCantImpagas.Name = "lblMinimoCantImpagas";
            lblMinimoCantImpagas.Size = new Size(151, 15);
            lblMinimoCantImpagas.TabIndex = 7;
            lblMinimoCantImpagas.Text = "Mínimo de cuotas impagas";
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultados.Location = new Point(12, 163);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(102, 25);
            lblResultados.TabIndex = 9;
            lblResultados.Text = "Resultados";
            // 
            // dgvInquilinosDeudores
            // 
            dgvInquilinosDeudores.AllowUserToAddRows = false;
            dgvInquilinosDeudores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInquilinosDeudores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInquilinosDeudores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInquilinosDeudores.Columns.AddRange(new DataGridViewColumn[] { ColCliente, ColNroAlquiler, ColInmueble, ColFechaInicio, ColMesesAlquiler, ColCantidadFacturasPagas, ColCantidadFacturasImpagas });
            dgvInquilinosDeudores.Location = new Point(12, 191);
            dgvInquilinosDeudores.Name = "dgvInquilinosDeudores";
            dgvInquilinosDeudores.ReadOnly = true;
            dgvInquilinosDeudores.RowTemplate.Height = 25;
            dgvInquilinosDeudores.Size = new Size(1240, 449);
            dgvInquilinosDeudores.TabIndex = 10;
            // 
            // ColCliente
            // 
            ColCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCliente.HeaderText = "Cliente";
            ColCliente.Name = "ColCliente";
            ColCliente.ReadOnly = true;
            // 
            // ColNroAlquiler
            // 
            ColNroAlquiler.HeaderText = "Nro. Alquiler";
            ColNroAlquiler.Name = "ColNroAlquiler";
            ColNroAlquiler.ReadOnly = true;
            // 
            // ColInmueble
            // 
            ColInmueble.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColInmueble.HeaderText = "Inmueble";
            ColInmueble.Name = "ColInmueble";
            ColInmueble.ReadOnly = true;
            // 
            // ColFechaInicio
            // 
            ColFechaInicio.HeaderText = "Fecha Inicio";
            ColFechaInicio.Name = "ColFechaInicio";
            ColFechaInicio.ReadOnly = true;
            ColFechaInicio.Width = 125;
            // 
            // ColMesesAlquiler
            // 
            ColMesesAlquiler.HeaderText = "Meses de Alquiler";
            ColMesesAlquiler.Name = "ColMesesAlquiler";
            ColMesesAlquiler.ReadOnly = true;
            ColMesesAlquiler.Width = 150;
            // 
            // ColCantidadFacturasPagas
            // 
            ColCantidadFacturasPagas.HeaderText = "Cantidad de Facturas Pagas";
            ColCantidadFacturasPagas.Name = "ColCantidadFacturasPagas";
            ColCantidadFacturasPagas.ReadOnly = true;
            ColCantidadFacturasPagas.Width = 200;
            // 
            // ColCantidadFacturasImpagas
            // 
            ColCantidadFacturasImpagas.HeaderText = "Cantidad de Facturas Impagas";
            ColCantidadFacturasImpagas.Name = "ColCantidadFacturasImpagas";
            ColCantidadFacturasImpagas.ReadOnly = true;
            ColCantidadFacturasImpagas.Width = 200;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(1097, 162);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(155, 23);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1097, 646);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 23);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // numCantImpagas
            // 
            numCantImpagas.Location = new Point(12, 113);
            numCantImpagas.Name = "numCantImpagas";
            numCantImpagas.Size = new Size(305, 23);
            numCantImpagas.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-9, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 100);
            panel1.TabIndex = 17;
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
            // FrmConsultarClientesDeudores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(numCantImpagas);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(dgvInquilinosDeudores);
            Controls.Add(lblResultados);
            Controls.Add(lblMinimoCantImpagas);
            Controls.Add(lblInquilinosDeudores);
            Controls.Add(lblFactura);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmConsultarClientesDeudores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarClientesDeudores";
            Load += FrmConsultarClientesDeudores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInquilinosDeudores).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantImpagas).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFactura;
        private Label lblInquilinosDeudores;
        private Label lblMinimoCantImpagas;
        private Label lblResultados;
        private DataGridView dgvInquilinosDeudores;
        private DataGridViewTextBoxColumn ColCliente;
        private DataGridViewTextBoxColumn ColNroAlquiler;
        private DataGridViewTextBoxColumn ColInmueble;
        private DataGridViewTextBoxColumn ColFechaInicio;
        private DataGridViewTextBoxColumn ColMesesAlquiler;
        private DataGridViewTextBoxColumn ColCantidadFacturasPagas;
        private DataGridViewTextBoxColumn ColCantidadFacturasImpagas;
        private Button btnConsultar;
        private Button btnSalir;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private NumericUpDown numCantImpagas;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}