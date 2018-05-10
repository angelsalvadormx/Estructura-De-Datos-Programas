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
        private int contador = 0;
        public void agregar_inicio(Contactos nuevo)
        {
            contador++;
            nuevo.Siguiente = inicio;
            inicio = nuevo;
        }
        public void eliminar_primero()
        {
            contador--;
            inicio = inicio.Siguiente;
        }
        public void eliminar_ultimo()
        {
            contador--;
            Contactos aux = inicio;
            while (aux.Siguiente.Siguiente != null)
                aux = aux.Siguiente;
            aux.Siguiente = null;
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
                inicio = _sigiente;
            }
        }
        public string reporteInverso()
        {
            string data =" ";
            Contactos aux;
            Contactos _ultimo = null;
            for (int i = 1; i <= contador; i++)
            {
               aux = inicio;
               while(aux.Siguiente != _ultimo)
                {
                    aux = aux.Siguiente;
                }
                _ultimo = aux;
                data += aux.String()+Environment.NewLine;
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
                while (aux.Siguiente != null)
                    aux = aux.Siguiente;
                aux.Siguiente = nuevo;
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
