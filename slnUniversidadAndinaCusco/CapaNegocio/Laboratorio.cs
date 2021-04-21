using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //atributos
        private string nombre;
        private string faculdad;
        private int numero;
        private string referencia;
        //propiedades
        public string Nombre 
        {
            get { return nombre; }//lectura de atributo
            set { nombre = value; } //excritura dek atributo
        }
        public string Facultad
        {
            get { return faculdad; }
            set { faculdad = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Referencia
        {
            get { return referencia; }
            set { referencia = value; }

        }

        //Metodos u operaciones 
        public string Estudiar()
        {
            return "No se ha implementado el metodo estudiar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el metodo aprobarExamen";
        }

    }
}
