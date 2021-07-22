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
        //void CargarDatos()
        //{
        //    try
        //    {
        //        DataTable dataGrado = ControladorMaestro.ObtenerGrado();
        //        DataTable dataSeccion = ControladorMaestro.ObtenerSeccion();
        //        DataTable dataTrimestre = ControladorMaestro.ObtenerTrimestre();
        //        DataTable dataPerfil = ControladorMaestro.ObtenerPerfil();

        //        if (dataTipoDoc != null && dataEstCivil != null)
        //        {
        //            CmbTipoDocumento.DataSource = dataTipoDoc;
        //            CmbTipoDocumento.DisplayMember = "tipoDocumento";
        //            CmbTipoDocumento.ValueMember = "idTipoDocumento";

        //            cmbEstCivil.DataSource = dataEstCivil;
        //            cmbEstCivil.DisplayMember = "estadocivil";
        //            cmbEstCivil.ValueMember = "idestadocivil";

        //            cmbMunicipios.DataSource = dataMunicipio;
        //            cmbMunicipios.DisplayMember = "municipio";
        //            cmbMunicipios.ValueMember = "idMunicipio";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar datos." + ex.Message, "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        //private void frmIngresoNotas_Load(object sender, EventArgs e)
        //{
        //    CargarDatos();
        //    CargarGridDatos();
        //}

        //void EnvioDatos()
        //{
        //    try
        //    {
        //        string nota;
        //        int idgrado, idseccion, idtrimestre, idperfil;
        //        //CREAR OBJETO DE CONTROLADOREMPLEADO
        //        ControladorMaestro objempleado;
        //        nombres = TxtNombres.Text;

        //        idestadocivil = Convert.ToInt16(cmbEstCivil.SelectedValue);
        //        idtipodocumento = Convert.ToInt16(CmbTipoDocumento.SelectedValue);
        //        idestadocivil = Convert.ToInt16(cmbEstCivil.SelectedValue); 
        //        idmunicipio = Convert.ToInt16(cmbMunicipios.SelectedValue);
        //        //INSTANCIAR OBJETO
        //        objempleado = new ControladorMaestro(nombres, apellidos, direccion, documento, nacimiento, idestadocivil, idtipodocumento, nit, idmunicipio);
        //        bool respuesta = objempleado.EnviarDatosController();
        //        if (respuesta == true)
        //        {
        //            MessageBox.Show("Usuario registrado exitosamente", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Usuario no pudo ser registrado", "Confirmación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Oops!, ocurrió un error al registrar al empleado, consulte con el administrador del sistema.", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //void CargarGridDatos()
        //{
        //    datosEmpleados = EmpleadosController.CargarEmpleados_Controller();
        //    dgvEmpleados.DataSource = datosEmpleados;
        //}

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
