using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
        
            if (txtPassword.Text.Trim ()==""||txtUsuario.Text.Trim()=="")
            {
                MessageBox.Show("Uno o ambos campos estan vacios.", "Campos vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                this.Hide();
                frmMenu formMenu = new frmMenu();
                formMenu.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
