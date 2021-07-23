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
            if (!Empty())
            {
                EnvioDatos();
                CargarGridDatos();
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos");
            }

        }

        private bool Empty()
        {
            string nombres, apellidos;
            int idMateria;
            nombres = txtNombres.Text;
            apellidos = txtApellidos.Text;
            idMateria = Convert.ToInt16(cmbMateria.SelectedValue);

            if (!String.IsNullOrEmpty(nombres) && !String.IsNullOrEmpty(apellidos) && !String.IsNullOrEmpty(Convert.ToString(idMateria)))
            {
                return false;
            }
            else
            {
                return true;
            }

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
                int idMateria;
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
                MessageBox.Show("Oops!, ocurrió un error al registrar al docente, consulte con el administrador del sistema." + er, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizarEmpl_Click(object sender, EventArgs e)
        {
            actualizarDocente();
        }

        private void actualizarDocente()
        {
            List<string> arrayDatosActu = new List<string>();
            string nombres = txtNombres.Text;
            arrayDatosActu.Add(nombres);

            string apellidos = txtApellidos.Text;
            arrayDatosActu.Add(apellidos);

            int idMateria = Convert.ToInt16(cmbMateria.SelectedValue);
            int id = getId();

            string s = Convert.ToString(cmbMateria.SelectedValue);
            arrayDatosActu.Add(s);


            if (!Empty() && Different(arrayDatosActu))
            {
                MessageBox.Show("yes they're diiff");

                ControladorMaestro objemaestro = new ControladorMaestro(nombres, apellidos, idMateria);
                bool res = ControladorMaestro.UpdateMaestro(id);
                if (res)
                {
                    MessageBox.Show("Actualizado Correctamente", "Confirmacion de actualizacion");
                    CargarGridDatos();
                }
                else
                {
                    MessageBox.Show("No pudo ser actualizado ", "Confirmacion de actualizacion");
                }
            }
            else
            {
                MessageBox.Show("Para Actualizar por favor cambia los datos del docente");
            }
        }

                private bool Different(List<string> arrayDatosNuevos)
                {
                    
                    int posicion = dgvDocentes.CurrentRow.Index;

                    string nombreOriginal = dgvDocentes[1, posicion].Value.ToString();
                    string apellidoOriginal = dgvDocentes[2, posicion].Value.ToString();
                    string materiaOriginal = dgvDocentes[3, posicion].Value.ToString();


            if (nombreOriginal == arrayDatosNuevos[0] && apellidoOriginal == arrayDatosNuevos[1] && materiaOriginal == arrayDatosNuevos[2])
                    {

                        return false;
                    }
                    else
                    {
                        return true;
                    }


                }        

        private void btnEliminarEmpl_Click(object sender, EventArgs e)
        {
            int id = getId();
            bool res = ControladorMaestro.EliminarDocente(id);

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

        private int getId()
        {
            int posicion = dgvDocentes.CurrentRow.Index;
            int   id  = Convert.ToInt16(dgvDocentes[0, posicion].Value.ToString());
            return id;
        }

        private void cmbMateria_Click(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddUser user = new frmAddUser();
        }
    }
}
