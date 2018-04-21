using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        private Contactos[] agenda = new Contactos[15];
        private int pos = 0;
        
        public void agregar(Contactos newContacto)
        {
            agenda[pos] = newContacto;
        }
     
        public void insertar(Contactos insertar, int lugar)
        {
            for (int i = 14; i > lugar; i--)
            {
                agenda[i] = agenda[i--];
            }
            agenda[lugar] = insertar;
        }
        public Contactos buscar(long tel)
        {
            for (int i = 0; i <= pos; i++)
            {
                if (agenda[i].Telefono == tel)
                {
                    return agenda[i];
                }
            }
            return null;
        }

        public bool eliminar(long tel)
        {
            bool van = false;
            for (int i = 0; i <= pos; i++)
            {
                if (agenda[i].Telefono == tel)
                {
                    for (int j = 0; j < 14; j++)
                    {
                        agenda[j] = agenda[j+1];
                    }
                    van = true;
                }
            }
            
            return van;
        }    

        public string listar()
        {

            return " ";
        }
    }
}
