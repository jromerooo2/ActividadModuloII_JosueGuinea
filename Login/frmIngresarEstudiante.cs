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
            CargarEspecialidad();
        }

        void CargarEspecialidad()
        {
            try
            {
                DataTable dataEspecialidad = ControladorEstudiante.ObtenerEspecialidad();
                cmbEspecialidad.DataSource = ControladorEstudiante.ObtenerEspecialidad();
                cmbEspecialidad.DisplayMember = "especialidad";
                cmbEspecialidad.ValueMember = "idEspecialidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las Materias .", "Error de carga",
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
