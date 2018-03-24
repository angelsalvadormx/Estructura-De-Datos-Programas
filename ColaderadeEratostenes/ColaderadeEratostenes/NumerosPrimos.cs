using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaderadeEratostenes
{
    class NumerosPrimos
    {
        private int[] arreglo = new int[1000];


        public string cDE()
        {
            string cadena="";
            for(int x = 1; x < 1000; x++)
            {
                arreglo[x] = 1;
            }
            for(int x = 2; x < 1000; x++)
            {
                int divisor =1;
                for(int y = 2; y <= x; y++)
                {
                    if((x % y) == 0)
                    {
                        divisor++;
                    }
                }
                if (divisor == 2)
                {
                    for(int z = (x + x); z < 1000; z += x)
                    {
                        arreglo[z] = 0;
                    }
                }
            }
            for(int x = 2; x < 1000; x++)
            {
                if (arreglo[x] == 1)
                {
                    cadena += x + ",";
                }
            }
            return cadena;
        }
    }
}
