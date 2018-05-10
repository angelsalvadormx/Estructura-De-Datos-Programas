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
        private Contactos ultimo;
        private int pos = 0;
        private int contador = 0;
        
        public void eliminar_primero()
        {
            contador--;
            inicio = inicio.Siguiente;
        }
        public void eliminar_ultimo()
        {
            ultimo = ultimo.Anterior;
         /*   contador--;
            Contactos aux = inicio;
            while (aux.Siguiente.Siguiente != null)
                aux = aux.Siguiente;
            aux.Siguiente = null;
            */
        }
        public void invertirLista()
        {
            Contactos aux = inicio;
            Contactos _sigiente;
            Contactos ultimo;
            while(aux.Siguiente != null)
            {
                _sigiente = aux.Siguiente;
                ultimo = _sigiente.Siguiente;
                _sigiente.Siguiente = inicio;
                aux.Siguiente = ultimo;
                inicio.Anterior = _sigiente;
                ultimo.Anterior = aux;
                inicio = _sigiente;
            }
        }
        public string reporteInverso()
        {
            string data =" ";
            Contactos aux = ultimo;
            if (aux.Anterior == null)
            {
                data = aux.String();
            }
            while(aux != null)
            {
                data += aux.String() + Environment.NewLine;
                aux = aux.Anterior;
            }
            return data;
        }
        public void agregar(Contactos nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Contactos aux = inicio;
                while (aux.Siguiente != ultimo)
                    aux = aux.Siguiente;
                nuevo.Anterior = aux;
                aux.Siguiente = nuevo;
                ultimo = nuevo;
            }
                contador++;
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
            while(aux != ultimo)
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
            while (aux != ultimo)
                if (aux.Siguiente.Telefono == tel)
                {
                    aux.Siguiente = aux.Siguiente.Siguiente;
                    return true;
                }
            return false;
        }    

        public string listar()
        {
            string str = "";
            Contactos aux = inicio;
            while(aux != ultimo)
            {
                str += aux.String();
                aux = aux.Siguiente;
            }
            return str;
        }
    }
}
