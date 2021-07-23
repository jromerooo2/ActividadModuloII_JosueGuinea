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
    public partial class frmIngresarEstudiante : Form
    {
        DataTable datosEstudiantes;

        public frmIngresarEstudiante()
        {
            InitializeComponent();
            //Metodos para cargar los tres combobox para ingresar los estudiantes.
            CargarEspecialidad();
            CargarGrado();
            CargarGenero();
            CargarGridDatos();
        }

        void CargarEspecialidad()
        {
            try
            {
                DataTable dataEspecialidad = ControladorEstudiante.ObtenerEspecialidad();
                cmbEspecialidad.DataSource = dataEspecialidad;
                cmbEspecialidad.DisplayMember = "especialidad";
                cmbEspecialidad.ValueMember = "idEspecialidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las especialidades .", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        void CargarGrado()
        {
            try
            {
                DataTable dataGrado = ControladorEstudiante.ObtenerGrado();
                cmbGrados.DataSource = dataGrado;
                cmbGrados.DisplayMember = "grados";
                cmbGrados.ValueMember = "idGrados";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los grados academicos .", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        void CargarGenero()
        {
            try
            {
                DataTable dataGenero = ControladorEstudiante.ObtenerGenero();
                cmbGeneros.DataSource = dataGenero;
                cmbGeneros.DisplayMember = "genero";
                cmbGeneros.ValueMember = "idGenero";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los generos .", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        void EnvioDatos()
        {
            try
            {
                string nombres, apellidos, direccion;
                int idEspecialidad, idGeneros, idGrado;
                nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
                direccion = txtDireccion.Text;
                idEspecialidad = Convert.ToInt16(cmbEspecialidad.SelectedValue);
                idGeneros = Convert.ToInt16(cmbGeneros.SelectedValue);
                idGrado = Convert.ToInt16(cmbGrados.SelectedValue);

                //INSTANCIAR OBJETO
                ControladorEstudiante objestudiante = new ControladorEstudiante(nombres, apellidos, direccion, idGrado, idEspecialidad, idGeneros);
                bool respuesta = objestudiante.EnviarDatosController();
                if (respuesta)
                {
                    MessageBox.Show("Usuario registrado exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario no pudo ser registrado", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Oops!, ocurrió un error al registrar al empleado, consulte con el administrador del sistema." + er, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarGridDatos()
        {
            datosEstudiantes = ControladorEstudiante.CargarAlumnos_Controller();
            dgvEstudiantes.DataSource = datosEstudiantes;
        }

        private void btnAgregarEstudiante_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarGridDatos();
        }



        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmIngresarEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarEmpl_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarEmpl_Click(object sender, EventArgs e)

        {

        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataToTextBox();
        }

        private void dataToTextBox()
        {
            
        }


        private int getId()
        {
            int posicion = dgvEstudiantes.CurrentRow.Index;
            int id = Convert.ToInt16(dgvEstudiantes[0, posicion].Value.ToString());
            return id;
        }

        private void btnEliminarEstudiante_Click(object sender, EventArgs e)
        {
            int id = getId();
            bool res = ControladorEstudiante.EliminarEstudiante(id);

            if (res)
            {
                MessageBox.Show("successfully deleted");
                CargarGridDatos();
            }
            else
            {
                MessageBox.Show("Not deleted");
            }
        }

        private void btnActualizarEstudiante_Click(object sender, EventArgs e)
        {

        }
    }
}
