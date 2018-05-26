using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
   public class Proceso
    {
        private int _duracion;
        private Proceso _siguiente;
        private int _numero;

        public Proceso(int duracion,int numero)
        {
            _numero = numero;
            _duracion = duracion;
            _siguiente = null;
        }
        public int Numero
        {
            get { return _numero; }
        }
        public Proceso Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public int Duracion{
            get{ return _duracion; }
            set { _duracion = value; }
        }
        public override string ToString()
        {
            return "Proceso "+_numero+" Duracion " + _duracion + Environment.NewLine; 
        }
    }
}
