using Controlador;
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
    public partial class frmIngresoNotas : Form
    {
        public frmIngresoNotas()
        {
            InitializeComponent();
            CargarGridDatos();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public DataTable datosEstudiantes;

        void CargarGridDatos()
        {
            CargarPeriodo();
            CargarMaterias();
            cargarAlumnos();
        }

        void cargarAlumnos()
        {
            datosEstudiantes = ControladorEstudiante.CargarAlumnos_Controller2();
            dgvAlumnos.DataSource = datosEstudiantes;
        }

        void CargarMaterias()
        {
            try
            {
                DataTable dataTipoDoc = ControladorMaestro.ObtenerMaterias();
                cmbMateria.DataSource = dataTipoDoc;
                cmbMateria.DisplayMember = "nombreMateria";
                cmbMateria.ValueMember = "idMateria";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las Materias .", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
        void CargarPeriodo()
        {
            try
            {
                DataTable dataTipoDoc = ControladorMaestro.ObtenerPeriodo();
                cmbPeriodo.DataSource = dataTipoDoc;
                cmbPeriodo.DisplayMember = "periodo";
                cmbPeriodo.ValueMember = "idPeriodo";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar las Materias .", "Error de carga",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dgvAlumnos.CurrentRow.Index;
            string NombreAlumno = dgvAlumnos[1, posicion].Value.ToString();
            int id  =  Convert.ToInt16(dgvAlumnos[0, posicion].Value.ToString());
            frmMostarNota mostrar = new frmMostarNota(id, NombreAlumno);
            mostrar.Show();

        }


        private void BtnConectar_Click(object sender, EventArgs e)
        {
            
        }

        void EnvioDatos()
        {                     
                try
                {
                    int Nota, IdAlumno, IdPeriodo, IdMateria ;
                    int posicion = dgvAlumnos.CurrentRow.Index;

                    IdAlumno = Convert.ToInt16(dgvAlumnos[0, posicion].Value.ToString());
                        
                    Nota = Convert.ToInt16(dgvAlumnos[2, posicion].Value.ToString());

                    IdPeriodo = Convert.ToInt16(cmbPeriodo.SelectedValue);

                    IdMateria = Convert.ToInt16(cmbMateria.SelectedValue);

                //MessageBox.Show("Value of Period : "+IdPeriodo);
                //MessageBox.Show("Value of Materia : " + IdMateria);

                ControladorIngresoNotas objestudiante = new ControladorIngresoNotas(IdAlumno, IdMateria, IdPeriodo, Nota);

                    bool respuesta = objestudiante.EnviarDatosController();
                    if (respuesta)
                    {
                        MessageBox.Show("Notas  exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Notas no pudieron ser ingresadas", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Oops!, ocurrió un error al registrar al empleado, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }            
        }
        private void btnIngresoNota_Click(object sender, EventArgs e)
        {
            EnvioDatos();
        }

        private void frmIngresoNotas_Load(object sender, EventArgs e)
        {
            CargarNotas();
        }

        private void CargarNotas()
        {
            //throw new NotImplementedException();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcionPerfil_Click(object sender, EventArgs e)
        {

        }

        private void lblPorcentajeAct_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}