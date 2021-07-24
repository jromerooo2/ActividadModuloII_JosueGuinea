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
            //Enviando datos hacia los text box
            string nombre, apellido, nota;

            nombre = dgvAlumnos[0, posicion].Value.ToString();
            apellido = dgvAlumnos[1, posicion].Value.ToString();
            nota = dgvAlumnos[2, posicion].Value.ToString();

        }


        private void BtnConectar_Click(object sender, EventArgs e)
        {

        }

        void EnvioDatos()
        {                     
                try
                {
                    int Nota;
                    int posicion = dgvAlumnos.CurrentRow.Index;
                    string nombreAlumnos, apellidoAlumno;
                    nombreAlumnos = dgvAlumnos[0, posicion].Value.ToString();
                    apellidoAlumno = dgvAlumnos[1, posicion].Value.ToString();
                    Nota = Convert.ToInt16(dgvAlumnos[2, posicion].Value.ToString());

                    ControladorIngresoNotas objestudiante = new ControladorIngresoNotas(nombreAlumnos, apellidoAlumno, Nota);

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
            try
            {
                int Nota;
                int posicion = dgvAlumnos.CurrentRow.Index;
                string nombreAlumnos, apellidoAlumno;
                nombreAlumnos = dgvAlumnos[0, posicion].Value.ToString();
                apellidoAlumno = dgvAlumnos[1, posicion].Value.ToString();
                Nota = Convert.ToInt16(dgvAlumnos[2, posicion].Value.ToString());

                ControladorIngresoNotas objestudiante = new ControladorIngresoNotas(nombreAlumnos, apellidoAlumno, Nota);      
                
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

        private void frmIngresoNotas_Load(object sender, EventArgs e)
        {

        }
    }
}