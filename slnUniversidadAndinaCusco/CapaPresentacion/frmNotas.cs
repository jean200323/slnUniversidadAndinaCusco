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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        //Instanciar la clases a traves de un objeto
        CapaNegocio.Notas nota1 = new CapaNegocio.Notas();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Estudiar());
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombre = txtNombre.Text;
            string facultad = txtFacultad.Text;
            int nota = int.Parse(txtNota.Text);
            int creditos = int.Parse(txtCreditos.Text);
            nota1.Nombre = nombre;
            nota1.Facultad = facultad;
            nota1.Nota = nota;
            nota1.Creditos = creditos;
            MessageBox.Show("se han registrado correctamente los datos de la nota 1");
        }

        private void btnEscrbrir_Click(object sender, EventArgs e)
        {
            string nombre = nota1.Nombre;
            string facultad = txtFacultad.Text;
            int nota = int.Parse(txtNota.Text);
            int creditos = int.Parse(txtCreditos.Text);
            nota1.Nombre = nombre;
            nota1.Facultad = facultad;
            nota1.Nota = nota;
            nota1.Creditos = creditos;
            MessageBox.Show("se han registrado correctamente los datos de la asignatura 1");
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Trabajar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nota1.Desaprobar());
        }
    }
}
