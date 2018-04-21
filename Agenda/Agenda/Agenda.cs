using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        private Contactos inicio;
        private int pos = 0;
        
        public void agregar(Contactos nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Contactos aux = inicio;
                while (aux.Siguiente != null)
                    aux = aux.Siguiente;
                aux.Siguiente = nuevo;
            }
        }
     /*
        public void insertar(Contactos insertar, int lugar)
        {
            for (int i = 14; i > lugar; i--)
            {
                agenda[i] = agenda[i--];
            }
            agenda[lugar] = insertar;
        }

    */
        public Contactos buscar(long tel)
        {
            Contactos aux = inicio;
            while(aux != null)
            {
                if (aux.Telefono == tel)
                {
                    return aux;
                }
                aux = aux.Siguiente;
            }
            return null;
        }

        public bool eliminar(long tel)
        {
            Contactos aux = inicio;
            while (aux.Siguiente != null)
                if (aux.Siguiente.Telefono == tel)
                {
                    aux.Siguiente = aux.Siguiente.Siguiente;
                    return true;
                }
            return false;
        }    

        public string listar()
        {

            return " ";
        }
    }
}
