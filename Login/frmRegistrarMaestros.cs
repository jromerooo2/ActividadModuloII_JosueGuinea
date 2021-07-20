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
    public partial class frmRegistrarMaestros : Form
    {
        public frmRegistrarMaestros()
        {
            InitializeComponent();
        }

        private void btnAgregarEmpl_Click(object sender, EventArgs e)
        {
            EnvioDatos();
        }


        //CRUD

        
        void EnvioDatos()
        {
            try
            {
                string nombres, apellidos;
                int  idMateria, iddocente;
                nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
                iddocente = Convert.ToInt16(txtID.Text);
                idMateria = Convert.ToInt16(cmbGenero.SelectedValue);


                //INSTANCIAR OBJETO
                ControladorMaestro objmaestro = new ControladorMaestro(nombres, apellidos, iddocente, idMateria);
                bool respuesta = objmaestro.EnviarDatosController();
                if (respuesta == true)
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no pudo ser registrado", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Oops!, ocurrió un error al registrar al empleado, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
