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
    public partial class FrmIngresoPerfil : Form
    {
        public FrmIngresoPerfil()
        {
            InitializeComponent();
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void FrmIngresoPerfil_Load(object sender, EventArgs e)
        {
            if (ControladorMaestro.CargarPeriodos() != null)
            {
                CmbPeriodo.DataSource = ControladorMaestro.CargarPeriodos();
                CmbPeriodo.ValueMember = "idPeriodo";
                CmbPeriodo.DisplayMember = "periodo";
            }
        }

        private void CmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
