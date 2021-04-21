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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        //Instanciar la clases a traves de un objeto
        CapaNegocio.Alumno alumno1 = new CapaNegocio.Alumno();


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apellidos = alumno1.Apellidos;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarNacimiento = txtLugarNacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarNacimiento;
            MessageBox.Show("se han registrado correctamente los datos del Alumno 1");

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string LugarNacimiento = txtLugarNacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = LugarNacimiento;
            MessageBox.Show("se han registrado correctamente los datos del Alumno 1");
        }

        private void txtLugarNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.Estudiar());
        }

        private void btntrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.Trabajar());
        }

        private void btnAprobarExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.AprobarExamen());
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
