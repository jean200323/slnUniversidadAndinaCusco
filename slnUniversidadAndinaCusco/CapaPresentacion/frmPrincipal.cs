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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //llamar al formulario del alumno 
            frmAlumno formulario = new frmAlumno();
            formulario.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //lamar al formulario docente 
            frmDocente Formulario = new frmDocente();
            Formulario.Show();

        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaboratorio Formulario = new frmLaboratorio();
            Formulario.Show();

        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignatura Formulario = new frmAsignatura();
            Formulario.Show();

        }

        private void jefePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJefePracticas Formulario = new frmJefePracticas();
            Formulario.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas Formulario = new frmNotas();
            Formulario.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRector Formulario = new frmRector();
            Formulario.Show();
        }

        private void pPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPpp Formulario = new frmPpp();
            Formulario.Show();

        }
    }
}
