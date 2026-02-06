using AppCalculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppCalculadora.Formularios
{
    public partial class frmRegistro : Form
    {
        List<Persona> personas = new List<Persona>();
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            personas.Add(new Persona() { Nombre = txtNombre.Text,Apellidos = txtApellidos.Text, Fecha = dtpFechaNacimiento.Value });
            MessageBox.Show("Persona registrada con exito");
            txtApellidos.Clear();
            txtNombre.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvMostrar.DataSource = null;
                dgvMostrar.DataSource=personas;
            }
        }
    }
}
