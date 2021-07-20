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
        public DataTable datosDocentes;

        public frmRegistrarMaestros()
        {
            InitializeComponent();
        }
        private void frmRegistrarMaestros_Load(object sender, EventArgs e)
        {
            CargarMaterias();
            CargarGridDatos();
        }

        private void btnAgregarEmpl_Click(object sender, EventArgs e)
        {
            EnvioDatos();
            CargarGridDatos();
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

        void CargarGridDatos()
        {
            datosDocentes = ControladorMaestro.CargarDocentes_Controller();
            dgvDocentes.DataSource = datosDocentes;
        }

        //CRUD


        void EnvioDatos()
        {
            try
            {
                string nombres, apellidos;
                int  idMateria;
                nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
                idMateria = Convert.ToInt16(cmbMateria.SelectedValue);

                //MessageBox.Show(Convert.ToString(cmbMateria.SelectedValue));

                //INSTANCIAR OBJETO
                ControladorMaestro objmaestro = new ControladorMaestro(nombres, apellidos, idMateria);
                bool respuesta = objmaestro.EnviarDatosController();
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
                MessageBox.Show("Oops!, ocurrió un error al registrar al empleado, consulte con el administrador del sistema."+ er, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        void DataToTextBox()
        {
            int posicion = dgvDocentes.CurrentRow.Index;

            txtNombres.Text = dgvDocentes[1, posicion].Value.ToString();
            txtApellidos.Text = dgvDocentes[2, posicion].Value.ToString();
            txtID.Text = dgvDocentes[0, posicion].Value.ToString();

            //CMB Values

            int idmateria = Convert.ToInt16(dgvDocentes[3, posicion].Value.ToString());
            cmbMateria.DataSource = ControladorMaestro.CargarMateriaInner(idmateria);
            cmbMateria.DisplayMember = "nombreMateria";
            cmbMateria.ValueMember = "idMateria";
        }

        private void dgvDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //enviar data a los textbox
            DataToTextBox();
        }

    }
}
