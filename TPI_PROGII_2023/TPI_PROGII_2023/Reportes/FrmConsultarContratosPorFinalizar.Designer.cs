namespace InmobiliariaFront.Reportes
{
    partial class FrmConsultarContratosPorFinalizar
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
            numMesesVencimiento = new NumericUpDown();
            btnSalir = new Button();
            btnConsultar = new Button();
            dgvContratosPorFinalizar = new DataGridView();
            ColPropietario = new DataGridViewTextBoxColumn();
            ColInmueble = new DataGridViewTextBoxColumn();
            ColBarrio = new DataGridViewTextBoxColumn();
            ColDireccion = new DataGridViewTextBoxColumn();
            ColFechaFin = new DataGridViewTextBoxColumn();
            ColTransaccion = new DataGridViewTextBoxColumn();
            lblResultados = new Label();
            lblMesesVence = new Label();
            lblContratosFinalizar = new Label();
            lblFactura = new Label();
            lblTipoContrato = new Label();
            cboTipoContrato = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numMesesVencimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvContratosPorFinalizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // numMesesVencimiento
            // 
            numMesesVencimiento.Location = new Point(12, 114);
            numMesesVencimiento.Name = "numMesesVencimiento";
            numMesesVencimiento.Size = new Size(305, 23);
            numMesesVencimiento.TabIndex = 24;
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
            // dgvContratosPorFinalizar
            // 
            dgvContratosPorFinalizar.AllowUserToAddRows = false;
            dgvContratosPorFinalizar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvContratosPorFinalizar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvContratosPorFinalizar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContratosPorFinalizar.Columns.AddRange(new DataGridViewColumn[] { ColPropietario, ColInmueble, ColBarrio, ColDireccion, ColFechaFin, ColTransaccion });
            dgvContratosPorFinalizar.Location = new Point(12, 192);
            dgvContratosPorFinalizar.Name = "dgvContratosPorFinalizar";
            dgvContratosPorFinalizar.ReadOnly = true;
            dgvContratosPorFinalizar.RowTemplate.Height = 25;
            dgvContratosPorFinalizar.Size = new Size(1240, 449);
            dgvContratosPorFinalizar.TabIndex = 21;
            // 
            // ColPropietario
            // 
            ColPropietario.HeaderText = "Propietario";
            ColPropietario.Name = "ColPropietario";
            ColPropietario.ReadOnly = true;
            ColPropietario.Width = 200;
            // 
            // ColInmueble
            // 
            ColInmueble.HeaderText = "Inmueble";
            ColInmueble.Name = "ColInmueble";
            ColInmueble.ReadOnly = true;
            ColInmueble.Width = 200;
            // 
            // ColBarrio
            // 
            ColBarrio.HeaderText = "Barrio";
            ColBarrio.Name = "ColBarrio";
            ColBarrio.ReadOnly = true;
            ColBarrio.Width = 200;
            // 
            // ColDireccion
            // 
            ColDireccion.HeaderText = "Direccion";
            ColDireccion.Name = "ColDireccion";
            ColDireccion.ReadOnly = true;
            ColDireccion.Width = 200;
            // 
            // ColFechaFin
            // 
            ColFechaFin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColFechaFin.HeaderText = "Fecha de finalización";
            ColFechaFin.Name = "ColFechaFin";
            ColFechaFin.ReadOnly = true;
            // 
            // ColTransaccion
            // 
            ColTransaccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTransaccion.HeaderText = "Transaccion";
            ColTransaccion.Name = "ColTransaccion";
            ColTransaccion.ReadOnly = true;
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
            // lblMesesVence
            // 
            lblMesesVence.AutoSize = true;
            lblMesesVence.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMesesVence.Location = new Point(12, 96);
            lblMesesVence.Name = "lblMesesVence";
            lblMesesVence.Size = new Size(135, 15);
            lblMesesVence.TabIndex = 19;
            lblMesesVence.Text = "En cuántos meses vence";
            // 
            // lblContratosFinalizar
            // 
            lblContratosFinalizar.AutoSize = true;
            lblContratosFinalizar.BackColor = Color.Navy;
            lblContratosFinalizar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblContratosFinalizar.ForeColor = Color.White;
            lblContratosFinalizar.Location = new Point(12, 35);
            lblContratosFinalizar.Name = "lblContratosFinalizar";
            lblContratosFinalizar.Size = new Size(359, 25);
            lblContratosFinalizar.TabIndex = 18;
            lblContratosFinalizar.Text = "Contratos de Intermediación por finalizar";
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
            // lblTipoContrato
            // 
            lblTipoContrato.AutoSize = true;
            lblTipoContrato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoContrato.Location = new Point(323, 96);
            lblTipoContrato.Name = "lblTipoContrato";
            lblTipoContrato.Size = new Size(94, 15);
            lblTipoContrato.TabIndex = 25;
            lblTipoContrato.Text = "Tipo de contrato";
            // 
            // cboTipoContrato
            // 
            cboTipoContrato.FormattingEnabled = true;
            cboTipoContrato.Location = new Point(323, 114);
            cboTipoContrato.Name = "cboTipoContrato";
            cboTipoContrato.Size = new Size(305, 23);
            cboTipoContrato.TabIndex = 27;
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
            panel1.Location = new Point(-8, -21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 100);
            panel1.TabIndex = 28;
            // 
            // FrmConsultarContratosPorFinalizar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(cboTipoContrato);
            Controls.Add(lblTipoContrato);
            Controls.Add(numMesesVencimiento);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(dgvContratosPorFinalizar);
            Controls.Add(lblResultados);
            Controls.Add(lblMesesVence);
            Controls.Add(lblContratosFinalizar);
            Controls.Add(lblFactura);
            Controls.Add(panel1);
            Name = "FrmConsultarContratosPorFinalizar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarContratosPorFinalizar";
            Load += FrmConsultarContratosPorFinalizar_Load;
            ((System.ComponentModel.ISupportInitialize)numMesesVencimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvContratosPorFinalizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numMesesVencimiento;
        private Button btnSalir;
        private Button btnConsultar;
        private DataGridView dgvContratosPorFinalizar;
        private Label lblResultados;
        private Label lblMesesVence;
        private Label lblContratosFinalizar;
        private Label lblFactura;
        private Label lblTipoContrato;
        private ComboBox cboTipoContrato;
        private DataGridViewTextBoxColumn ColPropietario;
        private DataGridViewTextBoxColumn ColInmueble;
        private DataGridViewTextBoxColumn ColBarrio;
        private DataGridViewTextBoxColumn ColDireccion;
        private DataGridViewTextBoxColumn ColFechaFin;
        private DataGridViewTextBoxColumn ColTransaccion;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}