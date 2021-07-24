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
    public partial class frmMostarNota : Form
    {
        public DataTable datosEstudiante; 
        public frmMostarNota(int id, string nombreAlumno)
        {
            InitializeComponent();
            CargarAlumno(id, nombreAlumno);
        }

        private void frmMostarNota_Load(object sender, EventArgs e)
        {
            CargarGridNotas();
        }

        private void CargarGridNotas()
        {
            datosEstudiante = ;
            dgvNotas.DataSource = datosEstudiante;
        }

        private void CargarAlumno(int id, string nombreAl)
        {
            MessageBox.Show("Id = "+ id);
            lblNombre.Text = nombreAl;
        }
    }
}
