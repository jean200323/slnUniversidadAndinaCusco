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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string apellidos = rector1.Apellidos;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string profesion = txtProfesion.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Edad = edad;
            rector1.Profesion = profesion;
            MessageBox.Show("se han registrado correctamente los datos del docente 1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Trabajar());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Ejecutar());
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string profesion = txtProfesion.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Edad = edad;
            rector1.Profesion = profesion;
            MessageBox.Show("se han registrado correctamente los datos del rector 1");
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Preparar());
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Evaluar());
        }
    }
}
