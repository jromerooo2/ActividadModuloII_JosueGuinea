﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {

            if (txtPassword.Text.Trim()==""||txtUsuario.Text.Trim()=="")
            {
                MessageBox.Show("Uno o ambos cambios estan vacios", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                EnvioDatosLog();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void EnvioDatosLog()
        {
            
            AtributosLogin.usuario = txtUsuario.Text;
            AtributosLogin.rolUsuario = 2;
            string passwordUsuariocrp = Encrypt.GetMD5(txtPassword.Text);
            AtributosLogin.passwordUsuario = passwordUsuariocrp;
            bool acceso = ControladorLogin.Acceso_Controller();
            if (acceso==true )
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o clave incorrecto, verifique sus credenciales", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }

    
}
