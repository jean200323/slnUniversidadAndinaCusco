using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //atributos 
        private string apellidos;
        private string nombres;
        private int edad;
        private string profesion;
        //propiedades
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        //Metodos u operaciones 
        public string Preparar()
        {
            return "No se ha implementado el metodo preparar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string Evaluar()
        {
            return "No se ha implementado el metodo aprobar";
        }
        public string Ejecutar()
        {
            return "No se ha implementado el metodo desaprobar";
        }
    }
}
