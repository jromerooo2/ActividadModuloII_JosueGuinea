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
            CargarGridNotas(id);
        }

        private void frmMostarNota_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarGridNotas(int id)
        {
            datosEstudiante = ControladorIngresoNotas.TraerNotasPorAlumno(id);
            dgvNotas.DataSource = datosEstudiante;
        }

        private void CargarAlumno(int id, string nombreAl)
        {
            //MessageBox.Show("Id = "+ id);
            lblNombre.Text = nombreAl;
        }
    }
}
