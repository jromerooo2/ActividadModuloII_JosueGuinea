using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Login
{
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
            if (AtributosLogin.rolUsuario != 2)
            {
                MessageBox.Show("Esta vista no es para ti");
                this.Close();
            }
            else
            {
                txtName.Text = AtributosLogin.usuario;
            }
        }

        private void btnIngresarPerfil_Click(object sender, EventArgs e)
        {
            frmAddUser ingreso = new frmAddUser();
            ingreso.Show();
            this.Hide();
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            frmRegistrarMaestros ingreso = new frmRegistrarMaestros();
            ingreso.Show();
            this.Hide();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmIngresarEstudiante ingreso = new frmIngresarEstudiante();
            ingreso.Show();
            this.Hide();
        }
    }
}
