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
    public partial class frmJefePracticas : Form
    {
        public frmJefePracticas()
        {
            InitializeComponent();
        }

        CapaNegocio.jefePractica jefePractica1 = new CapaNegocio.jefePractica();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Trabajar());
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string profesion = txtProfesion.Text;
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Nombres = nombres;
            jefePractica1.Edad = edad;
            jefePractica1.Profesion = profesion;
            MessageBox.Show("se han registrado correctamente los datos del jefePractica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = jefePractica1.Apellidos;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string profesion = txtProfesion.Text;
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Nombres = nombres;
            jefePractica1.Edad = edad;
            jefePractica1.Profesion = profesion;
            MessageBox.Show("se han registrado correctamente los datos del jefePractica 1");
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Preparar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Desaprobar());
        }
    }
}
