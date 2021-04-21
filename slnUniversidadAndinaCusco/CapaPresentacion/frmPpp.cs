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
    public partial class frmPpp : Form
    {
        public frmPpp()
        {
            InitializeComponent();
        }
        //Instanciar la clases a traves de un objeto
        CapaNegocio.Ppp ppp1 = new CapaNegocio.Ppp();
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Estudiar());
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer los datos del formulario
            string nombre = txtNombre.Text;
            string Lugar = txtlugar.Text;
            int duracion = int.Parse(txtDuracion.Text);
            int creditos = int.Parse(txtCreditos.Text);
            ppp1.Nombre = nombre;
            ppp1.Lugar = Lugar;
            ppp1.Duracion = duracion;
            ppp1.Creditos = creditos;
            MessageBox.Show("se han registrado correctamente los datos de ppp 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombre = ppp1.Nombre;
            string lugar = ppp1.Lugar;
            int duracion = int.Parse(txtDuracion.Text);
            int creditos = int.Parse(txtCreditos.Text);
            ppp1.Nombre = nombre;
            ppp1.Lugar = lugar;
            ppp1.Duracion = duracion;
            ppp1.Creditos = creditos;
            MessageBox.Show("se han registrado correctamente los datos de ppp 1");
        }

        private void Trabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Trabajar());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Desaprobar());
        }
    }
}
