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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        //Instanciar la clases a traves de un objeto
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Estudiar());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Trabajar());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombre = txtNombre.Text;
            string facultad = txtFacultad.Text;
            int duracion = int.Parse(txtDuracion.Text);
            int creditos = int.Parse(txtCreditos.Text);
            asignatura1.Nombre = nombre;
            asignatura1.Facultad = facultad;
            asignatura1.Duracion = duracion;
            asignatura1.Creditos = creditos;
            MessageBox.Show("se han registrado correctamente los datos de la asignatura 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombre = asignatura1.Nombre;
            string facultad = txtFacultad.Text;
            int duracion = int.Parse(txtDuracion.Text);
            int creditos = int.Parse(txtCreditos.Text);
            asignatura1.Nombre = nombre;
            asignatura1.Facultad = facultad;
            asignatura1.Duracion = duracion;
            asignatura1.Creditos = creditos;
            MessageBox.Show("se han registrado correctamente los datos de la asignatura 1");
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Desaprobar());
        }
    }
}
