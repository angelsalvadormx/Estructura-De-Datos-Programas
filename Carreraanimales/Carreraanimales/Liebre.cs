using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carreraanimales
{
    class Liebre:Corredor
    {
        public Liebre()
        {
            _pasos = 0;
        }


        public override void avanzar()
        {
            int numero = num.Next(1, 11);
            if (numero < 3)
            {
                _pasos += 0;
            }
            else if (numero < 5) {
                _pasos += 9;
            }
            else if (numero < 6)
            {
                _pasos -= 12;
            }
            else if (numero < 9)
            {
                _pasos += 1;
            }
            else
            {
                _pasos -= 2;
                if (_pasos < 0)
                {
                    _pasos = 0;
                }
            }
        }
        public override string ToString()
        {
            return "Liebre en:" + this._pasos;
        }
    }
}
