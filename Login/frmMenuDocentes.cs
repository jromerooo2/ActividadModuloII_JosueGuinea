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
    public partial class frmMenuDocentes : Form
    {
        public frmMenuDocentes()
        {
            InitializeComponent();
            if (AtributosLogin.rolUsuario == 0)
            {
                MessageBox.Show("Esta vista no es para ti");
                this.Close();
            }
            else
            {
                txtNombre.Text = AtributosLogin.usuario;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            frmIngresoNotas ingreso = new frmIngresoNotas();
            ingreso.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmIngresarEstudiante form = new frmIngresarEstudiante();
            form.Show();
            this.Hide();
        }

        private void btnIngresarPerfil_Click(object sender, EventArgs e)
        {
            FrmIngresoPerfil form = new FrmIngresoPerfil();
            form.Show();
            this.Hide();
        }

        private void frmMenuDocentes_Load(object sender, EventArgs e)
        {

        }
    }
}
