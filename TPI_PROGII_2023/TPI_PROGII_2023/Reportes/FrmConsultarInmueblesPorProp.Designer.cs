namespace InmobiliariaFront.Reportes
{
    partial class FrmConsultarInmueblesPorProp
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
            dgvInmueblesProp = new DataGridView();
            ColPropietario = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            lblCantidadMinima = new Label();
            numCantidad = new NumericUpDown();
            btnSalir = new Button();
            btnConsultar = new Button();
            lblResultados = new Label();
            lblInmueblesProp = new Label();
            lblFactura = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvInmueblesProp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInmueblesProp
            // 
            dgvInmueblesProp.AllowUserToAddRows = false;
            dgvInmueblesProp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInmueblesProp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInmueblesProp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInmueblesProp.Columns.AddRange(new DataGridViewColumn[] { ColPropietario, ColCantidad });
            dgvInmueblesProp.Location = new Point(12, 192);
            dgvInmueblesProp.Name = "dgvInmueblesProp";
            dgvInmueblesProp.ReadOnly = true;
            dgvInmueblesProp.RowTemplate.Height = 25;
            dgvInmueblesProp.Size = new Size(1240, 449);
            dgvInmueblesProp.TabIndex = 56;
            // 
            // ColPropietario
            // 
            ColPropietario.FillWeight = 194.923859F;
            ColPropietario.HeaderText = "Propietario";
            ColPropietario.Name = "ColPropietario";
            ColPropietario.ReadOnly = true;
            ColPropietario.Width = 750;
            // 
            // ColCantidad
            // 
            ColCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCantidad.FillWeight = 5.07614136F;
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            // 
            // lblCantidadMinima
            // 
            lblCantidadMinima.AutoSize = true;
            lblCantidadMinima.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadMinima.Location = new Point(12, 95);
            lblCantidadMinima.Name = "lblCantidadMinima";
            lblCantidadMinima.Size = new Size(99, 15);
            lblCantidadMinima.TabIndex = 54;
            lblCantidadMinima.Text = "Cantidad minima";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(12, 115);
            numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(305, 23);
            numCantidad.TabIndex = 53;
            numCantidad.ValueChanged += numCantidad_ValueChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(1097, 647);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 23);
            btnSalir.TabIndex = 50;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(1097, 163);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(155, 23);
            btnConsultar.TabIndex = 49;
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
            lblResultados.TabIndex = 48;
            lblResultados.Text = "Resultados";
            // 
            // lblInmueblesProp
            // 
            lblInmueblesProp.AutoSize = true;
            lblInmueblesProp.BackColor = Color.Navy;
            lblInmueblesProp.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmueblesProp.ForeColor = Color.White;
            lblInmueblesProp.Location = new Point(12, 35);
            lblInmueblesProp.Name = "lblInmueblesProp";
            lblInmueblesProp.Size = new Size(232, 25);
            lblInmueblesProp.TabIndex = 46;
            lblInmueblesProp.Text = "Inmuebles por propietario";
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
            lblFactura.TabIndex = 45;
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
            panel1.Location = new Point(-7, -19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 100);
            panel1.TabIndex = 57;
            // 
            // FrmConsultarInmueblesPorProp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(dgvInmueblesProp);
            Controls.Add(lblCantidadMinima);
            Controls.Add(numCantidad);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(lblResultados);
            Controls.Add(lblInmueblesProp);
            Controls.Add(lblFactura);
            Controls.Add(panel1);
            Name = "FrmConsultarInmueblesPorProp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultarInmueblesPorProp";
            ((System.ComponentModel.ISupportInitialize)dgvInmueblesProp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInmueblesProp;
        private DataGridViewTextBoxColumn ColPropietario;
        private DataGridViewTextBoxColumn ColCantidad;
        private Label lblCantidadMinima;
        private NumericUpDown numCantidad;
        private Button btnSalir;
        private Button btnConsultar;
        private Label lblResultados;
        private Label lblInmueblesProp;
        private Label lblFactura;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}