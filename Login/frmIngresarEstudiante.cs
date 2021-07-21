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
    public partial class frmIngresarEstudiante : Form
    {
        public frmIngresarEstudiante()
        {
            InitializeComponent();
        }

        void CargarMaterias()
        {
            try
            {
                DataTable dataEspecialidad = .ObtenerMaterias();
                cmbEspecialidad.DataSource = dataEspecialidad;
                cmbEspecialidad.DisplayMember = "nombreMateria";
                cmbEspecialidad.ValueMember = "idMateria";
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
    }
}
