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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password, user, Cpassword;

            password = txtPassword.Text;
            user = txtUserName.Text;
            Cpassword = txtConfirmPassword.Text;
            int rol = comboBox1.SelectedIndex;

            if (!String.IsNullOrEmpty(password) && !String.IsNullOrEmpty(user) && !String.IsNullOrEmpty(Cpassword))
            {
                //MessageBox.Show("Not empty");
                bool res = ControladorUsuario.AgregarUsuario(password, user, rol);
                

            }
            else
            {
                //MessageBox.Show("empty");
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        public void showPass()
        {
            
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
