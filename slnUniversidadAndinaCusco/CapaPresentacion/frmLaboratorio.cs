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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }
        //Instanciar la clases a traves de un objeto
        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();

        private void button1_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombre = txtNombre.Text;
            string facultad = txtFacultad.Text;
            int numero = int.Parse(txtNumero.Text);
            string referencia = txtReferencia.Text;
            laboratorio1.Nombre = nombre;
            laboratorio1.Facultad = facultad;
            laboratorio1.Numero = numero;
            laboratorio1.Referencia = referencia;
            MessageBox.Show("se han registrado correctamente los datos del Alumno 1");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombre = laboratorio1.Nombre;
            string facultad = txtFacultad.Text;
            int numero = int.Parse(txtNumero.Text);
            string referencia = txtReferencia.Text;
            laboratorio1.Nombre = nombre;
            laboratorio1.Facultad = facultad;
            laboratorio1.Numero = numero;
            laboratorio1.Referencia = referencia;
            MessageBox.Show("se han registrado correctamente los datos del Alumno 1");
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Estudiar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Estudiar());
        }

        private void btnAprobarExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Estudiar());
        }
    }
}
