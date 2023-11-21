using InmobiliariaBack.Datos.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI_PROGII_2023;

namespace InmobiliariaFront.Reportes
{
    public partial class FrmLogin : Form
    {
        DaoLogin login = new DaoLogin();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int resultado = login.Login(txtUsuario.Text, txtContra.Text);
            if (resultado == 1)
            {
                FormPrincipal principal = new FormPrincipal();
                MessageBox.Show("Ha ingresado correctamente", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide(); 
                principal.ShowDialog();
                Close();
            }
            else if (resultado == 0)
            {
                MessageBox.Show("¡Usuario o contraseña incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;
        }
    }
}
