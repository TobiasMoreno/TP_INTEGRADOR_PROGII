namespace InmobiliariaFront
{
    partial class FrmAcercaDe
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
            lblFactura = new Label();
            lblInmobiliaria = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblFactura.Location = new Point(10, 63);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(150, 25);
            lblFactura.TabIndex = 3;
            lblFactura.Text = "GRUPO Nro: 13";
            // 
            // lblInmobiliaria
            // 
            lblInmobiliaria.AutoSize = true;
            lblInmobiliaria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInmobiliaria.Location = new Point(12, 9);
            lblInmobiliaria.Name = "lblInmobiliaria";
            lblInmobiliaria.Size = new Size(93, 21);
            lblInmobiliaria.TabIndex = 2;
            lblInmobiliaria.Text = "Inmobiliaria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 4;
            label1.Text = "Integrantes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 121);
            label2.Name = "label2";
            label2.Size = new Size(193, 20);
            label2.TabIndex = 5;
            label2.Text = "- Benegas, Joaquin Ezequiel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 145);
            label3.Name = "label3";
            label3.Size = new Size(173, 20);
            label3.TabIndex = 6;
            label3.Text = "- Córdoba Lion, Emanuel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 193);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 8;
            label4.Text = "- Peiretti Piconi, Mateo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(30, 169);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 7;
            label5.Text = "- Córdoba Lion, Luciano";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 241);
            label6.Name = "label6";
            label6.Size = new Size(177, 20);
            label6.TabIndex = 10;
            label6.Text = "- Vazquez, Lucas Ezequiel";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 217);
            label7.Name = "label7";
            label7.Size = new Size(183, 20);
            label7.TabIndex = 9;
            label7.Text = "- Moreno, Tobías Emiliano";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(256, 426);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(btnSalir);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblFactura);
            Controls.Add(lblInmobiliaria);
            Name = "FrmAcercaDe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAcercaDe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFactura;
        private Label lblInmobiliaria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSalir;
    }
}