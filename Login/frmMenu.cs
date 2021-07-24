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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            if (AtributosLogin.rolUsuario != 0)
            {
                MessageBox.Show("Esta vista no es para ti");
                this.Close();
            }
            else
            {
                txtNombre.Text = AtributosLogin.usuario;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmNotasAcademicas frmAcademicas = new frmNotasAcademicas();
            //frmAcademicas.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNotasTecnicas frmTecnicas = new frmNotasTecnicas();
            frmTecnicas.Show();
        }
    }
}
