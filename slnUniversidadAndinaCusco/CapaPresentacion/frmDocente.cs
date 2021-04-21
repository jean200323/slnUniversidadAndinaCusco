using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();

        private void button1_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string profesion = txtProfesion.Text;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.Edad = edad;
            docente1.Profesion = profesion;
            MessageBox.Show("se han registrado correctamente los datos del docente 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = docente1.Apellidos;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string profesion = txtProfesion.Text;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.Edad = edad;
            docente1.Profesion = profesion;
            MessageBox.Show("se han registrado correctamente los datos del docente 1");
        }

        private void txtLugarNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Preparar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Trabajar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Desaprobar());
        }
    }
}
