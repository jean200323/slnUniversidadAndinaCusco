using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        //atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimineto;
        //propiedades
        public string Apellidos
        {
            get { return apellidos; }//lectura de atributo
            set { apellidos = value; } //excritura dek atributo
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Edad
        {
            get { return edad;}
            set { edad = value;}
        }

        public string LugarNacimiento
        {
            get { return lugarNacimineto; }
            set { lugarNacimineto = value; }

        }
        
        //Metodos u operaciones 
        public string Estudiar()
        {
            return "No se ha implementado el motodo estudiar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el motodo trabajar";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el motodo aprobarExamen";
        }


    }
}
