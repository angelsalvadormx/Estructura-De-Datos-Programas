using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreraanimales
{
    class Tortuga:Corredor
    {
        public Tortuga()
        {
            _pasos = 0;
        }


        public override void avanzar()
        {
            int numero = num.Next(1, 11);
            if (numero < 6)
            {
                _pasos += 3;
            }
            else if (numero < 8)
            {
                _pasos -= 6;
            }
            else
            {
                _pasos += 1;
            }
            if (_pasos < 0)
            {
                _pasos = 0;
            }
        }
        public override string ToString()
        {
            return "Tortuga en: " + this._pasos;
        }
    }
}
