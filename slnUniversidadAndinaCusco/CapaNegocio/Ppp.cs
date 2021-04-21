using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Ppp
    {
        //atributos 
        private string nombre;
        private string lugar;
        private int duracion;
        private int creditos;
        //propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }
        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }
        public int Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        //Metodos u operaciones 
        public string Estudiar()
        {
            return "No se ha implementado el metodo Estudiar";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo trabajar";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo aprobar";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo desaprobar";
        }
    }
}
