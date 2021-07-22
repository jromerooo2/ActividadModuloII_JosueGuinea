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
        public frmIngresarEstudiante()
        {
            InitializeComponent();
            //Metodos para cargar los tres combobox para ingresar los estudiantes.
            CargarEspecialidad();
            CargarGrado();
            CargarGenero();
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
    }
}
