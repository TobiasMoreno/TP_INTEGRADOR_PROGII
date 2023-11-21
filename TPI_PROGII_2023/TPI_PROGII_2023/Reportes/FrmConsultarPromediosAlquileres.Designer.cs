namespace InmobiliariaFront.Reportes
{
    partial class FrmConsultarPromediosAlquileres
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
            dgvPromedioAlquileres = new DataGridView();
            ColPromedioDesde = new DataGridViewTextBoxColumn();
            ColPromedioHasta = new DataGridViewTextBoxColumn();
            ColDiferencia = new DataGridViewTextBoxColumn();
            ColPorcentajeAumento = new DataGridViewTextBoxColumn();
            numAñoHasta = new NumericUpDown();
            lblAñoHasta = new Label();
            numAñoDesde = new NumericUpDown();
            btnSalir = new Button();
            btnConsultar = new Button();
            lblResultados = new Label();
            lblAñoDesde = new Label();
            lblPromedioAlquileres = new Label();
            lblFactura = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPromedioAlquileres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAñoHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAñoDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPromedioAlquileres
            // 
            dgvPromedioAlquileres.AllowUserToAddRows = false;
            dgvPromedioAlquileres.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPromedioAlquileres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPromedioAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPromedioAlquileres.Columns.AddRange(new DataGridViewColumn[] { ColPromedioDesde, ColPromedioHasta, ColDiferencia, ColPorcentajeAumento });
            dgvPromedioAlquileres.Location = new Point(12, 192);
            dgvPromedioAlquileres.Name = "dgvPromedioAlquileres";
            dgvPromedioAlquileres.ReadOnly = true;
            dgvPromedioAlquileres.RowTemplate.Height = 25;
            dgvPromedioAlquileres.Size = new Size(1240, 449);
            dgvPromedioAlquileres.TabIndex = 47;
            // 
            // ColPromedioDesde
            // 
            ColPromedioDesde.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPromedioDesde.HeaderText = "Promedio desde";
            ColPromedioDesde.Name = "ColPromedioDesde";
            ColPromedioDesde.ReadOnly = true;
            // 
            // ColPromedioHasta
            // 
            ColPromedioHasta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPromedioHasta.HeaderText = "Promedio hasta";
            ColPromedioHasta.Name = "ColPromedioHasta";
            ColPromedioHasta.ReadOnly = true;
            // 
            // ColDiferencia
            // 
            ColDiferencia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDiferencia.HeaderText = "Diferencia";
            ColDiferencia.Name = "ColDiferencia";
            ColDiferencia.ReadOnly = true;
            // 
            // ColPorcentajeAumento
            // 
            ColPorcentajeAumento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPorcentajeAumento.HeaderText = "Porcentaje de aumento";
            ColPorcentajeAumento.Name = "ColPorcentajeAumento";
            ColPorcentajeAumento.ReadOnly = true;
            // 
            // numAñoHasta
            // 
            numAñoHasta.Location = new Point(323, 114);
            numAñoHasta.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numAñoHasta.Name = "numAñoHasta";
            numAñoHasta.Size = new Size(305, 23);
            numAñoHasta.TabIndex = 44;
            numAñoHasta.ValueChanged += numAñoHasta_ValueChanged;
            // 
            // lblAñoHasta
            // 
            lblAñoHasta.AutoSize = true;
            lblAñoHasta.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAñoHasta.Location = new Point(323, 96);
            lblAñoHasta.Name = "lblAñoHasta";
            lblAñoHasta.Size = new Size(60, 15);
            lblAñoHasta.TabIndex = 43;
            lblAñoHasta.Text = "Año hasta";
            // 
            // numAñoDesde
            // 
            numAñoDesde.Location = new Point(12, 114);
            numAñoDesde.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numAñoDesde.Name = "numAñoDesde";
            numAñoDesde.Size = new Size(305, 23);
            numAñoDesde.TabIndex = 42;
            numAñoDesde.ValueChanged += numAñoDesde_ValueChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1097, 647);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 23);
            btnSalir.TabIndex = 41;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(1097, 163);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(155, 23);
            btnConsultar.TabIndex = 40;
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
            lblResultados.TabIndex = 39;
            lblResultados.Text = "Resultados";
            // 
            // lblAñoDesde
            // 
            lblAñoDesde.AutoSize = true;
            lblAñoDesde.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAñoDesde.Location = new Point(12, 96);
            lblAñoDesde.Name = "lblAñoDesde";
            lblAñoDesde.Size = new Size(63, 15);
            lblAñoDesde.TabIndex = 38;
            lblAñoDesde.Text = "Año desde";
            // 
            // lblPromedioAlquileres
            // 
            lblPromedioAlquileres.AutoSize = true;
            lblPromedioAlquileres.BackColor = Color.Navy;
            lblPromedioAlquileres.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPromedioAlquileres.ForeColor = Color.White;
            lblPromedioAlquileres.Location = new Point(12, 35);
            lblPromedioAlquileres.Name = "lblPromedioAlquileres";
            lblPromedioAlquileres.Size = new Size(278, 25);
            lblPromedioAlquileres.TabIndex = 37;
            lblPromedioAlquileres.Text = "Promedio de alquileres por año";
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
            lblFactura.TabIndex = 36;
            lblFactura.Text = "CONSULTAR";
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
            panel1.Location = new Point(-7, -16);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 100);
            panel1.TabIndex = 48;
            // 
            // FrmConsultarPromediosAlquileres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvPromedioAlquileres);
            Controls.Add(numAñoHasta);
            Controls.Add(lblAñoHasta);
            Controls.Add(numAñoDesde);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(lblResultados);
            Controls.Add(lblAñoDesde);
            Controls.Add(lblPromedioAlquileres);
            Controls.Add(lblFactura);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmConsultarPromediosAlquileres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarPromediosAlquileres";
            Load += FrmConsultarPromediosAlquileres_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPromedioAlquileres).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAñoHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAñoDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPromedioAlquileres;
        private DataGridViewTextBoxColumn ColPromedioDesde;
        private DataGridViewTextBoxColumn ColPromedioHasta;
        private DataGridViewTextBoxColumn ColDiferencia;
        private DataGridViewTextBoxColumn ColPorcentajeAumento;
        private NumericUpDown numAñoHasta;
        private Label lblAñoHasta;
        private NumericUpDown numAñoDesde;
        private Button btnSalir;
        private Button btnConsultar;
        private Label lblResultados;
        private Label lblAñoDesde;
        private Label lblPromedioAlquileres;
        private Label lblFactura;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}