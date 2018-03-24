using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreraanimales
{
    class Corredor:Carrera
    {
        protected int _pasos;
        protected static Random num = new Random();


        public int Pasos
        {
            get { return _pasos; }
        }

        public virtual void avanzar()
        {

        }
    }
}
