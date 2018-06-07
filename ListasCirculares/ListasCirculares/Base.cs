using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Base
    {
        private string _nombre;
        private int _duracion;
        public Base _siguiente;

        public Base(string nombre, int duracion)
        {
            _nombre = nombre;
            _duracion = duracion;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Duracion
        {
            get { return _duracion; }
            set { _duracion = value; }
        }
        public Base Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public override string ToString()
        {
            return "Nombre: " + _nombre + " Duración: " + _duracion + Environment.NewLine;
        }

    }
}
