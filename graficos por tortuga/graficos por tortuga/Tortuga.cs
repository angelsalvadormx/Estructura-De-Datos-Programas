using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graficos_por_tortuga
{
    class Tortuga
    {
        private string[,] tablero = new string[20, 20];
        private int _j;
        private int _x = 0;
        private int _eje;
        private bool _pluma;

        public Tortuga() {
            _eje = 4;
            _pluma = false;
            _j = 2;
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                    tablero[i, j] = "0";
        }
        public bool pluma
        {
            get { return _pluma; }
            set { _pluma = value; }
        }

        public void Girar_Derecha()
        {
            if (_eje == 4)
                  _eje = 1;
            else
              _eje++;
        }

        public void Girar_izq()
        {
            if (_eje == 1)
                _eje = 4;
            else
                _eje--;
        }
        public bool Avanza(int cantidad)
        {
            switch (_eje)
            {
                case 1:
                    {
                        if ((_x - cantidad) >= 0)
                        {
                            if (_pluma)
                            {
                                int w = _x;
                                while (w >= (_x - cantidad))
                                {
                                    tablero[w, _j] = "*";
                                    w--;
                                }
                            }
                            else
                            {
                                _x = (_x-cantidad);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                            break;
                    }
                case 2:
                    {
                        if ((cantidad + _j) <= 20)
                        {
                            if (_pluma)
                            {
                                int w = _j;
                                while (w <= (cantidad + _j))
                                {
                                    tablero[_x, w] = "*";
                                    w++;
                                }
                            }
                            else
                            {
                                _j = (cantidad+_j);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    }
                case 3:
                    {
                        if ((cantidad+_x) <= 20)
                        {
                            if (_pluma)
                            {
                                int w = _x;
                                while (w <= (cantidad + _x))
                                {
                                    tablero[w, _j] = "*";
                                    w++;
                                }
                            }
                            else
                            {
                                _x = (cantidad+_x);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    }
                case 4:
                    {
                        if ((_j-cantidad) <= 0)
                        {
                            if (_pluma)
                            {
                                int w = _j;
                                while (w >= (_j-cantidad))
                                {
                                    tablero[_x, w] = "*";
                                    w--;
                                }
                            }
                            else
                            {
                                _j = (_j-cantidad);
                            }
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    }
                    
            }
            return false;
        }
        public override string ToString()
        {
            string str = " ";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    str += tablero[i, j]+" ";
                }
                str += Environment.NewLine;
            }
            return str;
        }
    }
}
