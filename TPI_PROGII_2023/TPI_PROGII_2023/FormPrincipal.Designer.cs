namespace TPI_PROGII_2023
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            soporteToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            inmueblesToolStripMenuItem = new ToolStripMenuItem();
            transacciónToolStripMenuItem = new ToolStripMenuItem();
            generarFacturaToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            inquilinosCumplidoresToolStripMenuItem = new ToolStripMenuItem();
            inquilinosDeudoresToolStripMenuItem = new ToolStripMenuItem();
            promedioDeAlquileresToolStripMenuItem = new ToolStripMenuItem();
            inmueblesCaptadosToolStripMenuItem = new ToolStripMenuItem();
            inmueblesDisponiblesToolStripMenuItem = new ToolStripMenuItem();
            inmueblesPorPropietarioToolStripMenuItem = new ToolStripMenuItem();
            contratosPorFinalizarToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            infoDesarrolloToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, transacciónToolStripMenuItem, reportesToolStripMenuItem, acercaDeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // soporteToolStripMenuItem
            // 
            soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, inmueblesToolStripMenuItem });
            soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            soporteToolStripMenuItem.Size = new Size(60, 20);
            soporteToolStripMenuItem.Text = "Soporte";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // inmueblesToolStripMenuItem
            // 
            inmueblesToolStripMenuItem.Name = "inmueblesToolStripMenuItem";
            inmueblesToolStripMenuItem.Size = new Size(180, 22);
            inmueblesToolStripMenuItem.Text = "Inmuebles";
            inmueblesToolStripMenuItem.Click += inmueblesToolStripMenuItem_Click;
            // 
            // transacciónToolStripMenuItem
            // 
            transacciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generarFacturaToolStripMenuItem });
            transacciónToolStripMenuItem.Name = "transacciónToolStripMenuItem";
            transacciónToolStripMenuItem.Size = new Size(81, 20);
            transacciónToolStripMenuItem.Text = "Transacción";
            // 
            // generarFacturaToolStripMenuItem
            // 
            generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            generarFacturaToolStripMenuItem.Size = new Size(157, 22);
            generarFacturaToolStripMenuItem.Text = "Generar Factura";
            generarFacturaToolStripMenuItem.Click += generarFacturaToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { inquilinosCumplidoresToolStripMenuItem, inquilinosDeudoresToolStripMenuItem, promedioDeAlquileresToolStripMenuItem, inmueblesCaptadosToolStripMenuItem, inmueblesDisponiblesToolStripMenuItem, inmueblesPorPropietarioToolStripMenuItem, contratosPorFinalizarToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // inquilinosCumplidoresToolStripMenuItem
            // 
            inquilinosCumplidoresToolStripMenuItem.Name = "inquilinosCumplidoresToolStripMenuItem";
            inquilinosCumplidoresToolStripMenuItem.Size = new Size(211, 22);
            inquilinosCumplidoresToolStripMenuItem.Text = "Inquilinos Cumplidores";
            inquilinosCumplidoresToolStripMenuItem.Click += inquilinosCumplidoresToolStripMenuItem_Click;
            // 
            // inquilinosDeudoresToolStripMenuItem
            // 
            inquilinosDeudoresToolStripMenuItem.Name = "inquilinosDeudoresToolStripMenuItem";
            inquilinosDeudoresToolStripMenuItem.Size = new Size(211, 22);
            inquilinosDeudoresToolStripMenuItem.Text = "Inquilinos Deudores";
            inquilinosDeudoresToolStripMenuItem.Click += inquilinosDeudoresToolStripMenuItem_Click;
            // 
            // promedioDeAlquileresToolStripMenuItem
            // 
            promedioDeAlquileresToolStripMenuItem.Name = "promedioDeAlquileresToolStripMenuItem";
            promedioDeAlquileresToolStripMenuItem.Size = new Size(211, 22);
            promedioDeAlquileresToolStripMenuItem.Text = "Promedio de Alquileres";
            promedioDeAlquileresToolStripMenuItem.Click += promedioDeAlquileresToolStripMenuItem_Click;
            // 
            // inmueblesCaptadosToolStripMenuItem
            // 
            inmueblesCaptadosToolStripMenuItem.Name = "inmueblesCaptadosToolStripMenuItem";
            inmueblesCaptadosToolStripMenuItem.Size = new Size(211, 22);
            inmueblesCaptadosToolStripMenuItem.Text = "Inmuebles Captados";
            inmueblesCaptadosToolStripMenuItem.Click += inmueblesCaptadosToolStripMenuItem_Click;
            // 
            // inmueblesDisponiblesToolStripMenuItem
            // 
            inmueblesDisponiblesToolStripMenuItem.Name = "inmueblesDisponiblesToolStripMenuItem";
            inmueblesDisponiblesToolStripMenuItem.Size = new Size(211, 22);
            inmueblesDisponiblesToolStripMenuItem.Text = "Inmuebles Disponibles";
            inmueblesDisponiblesToolStripMenuItem.Click += inmueblesDisponiblesToolStripMenuItem_Click;
            // 
            // inmueblesPorPropietarioToolStripMenuItem
            // 
            inmueblesPorPropietarioToolStripMenuItem.Name = "inmueblesPorPropietarioToolStripMenuItem";
            inmueblesPorPropietarioToolStripMenuItem.Size = new Size(211, 22);
            inmueblesPorPropietarioToolStripMenuItem.Text = "Inmuebles por Propietario";
            inmueblesPorPropietarioToolStripMenuItem.Click += inmueblesPorPropietarioToolStripMenuItem_Click;
            // 
            // contratosPorFinalizarToolStripMenuItem
            // 
            contratosPorFinalizarToolStripMenuItem.Name = "contratosPorFinalizarToolStripMenuItem";
            contratosPorFinalizarToolStripMenuItem.Size = new Size(211, 22);
            contratosPorFinalizarToolStripMenuItem.Text = "Contratos por Finalizar";
            contratosPorFinalizarToolStripMenuItem.Click += contratosPorFinalizarToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoDesarrolloToolStripMenuItem });
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(71, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // infoDesarrolloToolStripMenuItem
            // 
            infoDesarrolloToolStripMenuItem.Name = "infoDesarrolloToolStripMenuItem";
            infoDesarrolloToolStripMenuItem.Size = new Size(154, 22);
            infoDesarrolloToolStripMenuItem.Text = "Info. Desarrollo";
            infoDesarrolloToolStripMenuItem.Click += infoDesarrolloToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = InmobiliariaFront.Properties.Resources.aaaa;
            pictureBox1.Location = new Point(405, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MaximizeBox = false;
            MaximumSize = new Size(1280, 720);
            MinimumSize = new Size(1280, 720);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem soporteToolStripMenuItem;
        private ToolStripMenuItem transacciónToolStripMenuItem;
        private ToolStripMenuItem generarFacturaToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem infoDesarrolloToolStripMenuItem;
        private ToolStripMenuItem inquilinosDeudoresToolStripMenuItem;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ToolStripMenuItem inmueblesCaptadosToolStripMenuItem;
        private ToolStripMenuItem inmueblesDisponiblesToolStripMenuItem;
        private ToolStripMenuItem promedioDeAlquileresToolStripMenuItem;
        private ToolStripMenuItem contratosPorFinalizarToolStripMenuItem;
        private ToolStripMenuItem inmueblesPorPropietarioToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem inquilinosCumplidoresToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem inmueblesToolStripMenuItem;
    }
}