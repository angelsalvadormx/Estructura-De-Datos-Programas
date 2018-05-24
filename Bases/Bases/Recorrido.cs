using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    class Recorrido
    {
        private Base inicio;

        public void agregarFinal(Base nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.Siguiente = inicio;
            }
            else
            {
                Base aux = inicio;
                while (aux.Siguiente != inicio)
                {
                    aux = aux.Siguiente;
                }
                nuevo.Siguiente = inicio;
                aux.Siguiente = nuevo;
            }
        }
        public Base buscar(string nombre)
        {
            Base aux = inicio;
            if (aux.Nombre == nombre)
            {
                return aux;
            }
            aux = aux.Siguiente;
            while (aux != inicio)
            {
                if (aux.Nombre == nombre)
                {
                    return aux;
                }
                aux = aux.Siguiente;
            }
            return null;
        }

        public Base eliminarUltimo()
        {
             Base aux = inicio;
        
            while (aux.Siguiente.Siguiente != inicio)
            {
                aux = aux.Siguiente;
            }
            Base _aux = aux.Siguiente;
            aux.Siguiente = inicio;
            return _aux;

        }

        public Base eliminarInicio()
        {
            Base aux = inicio;
            Base aux2 = inicio;
            while (aux.Siguiente != inicio)
            {
                aux = aux.Siguiente;
            }
            inicio = inicio.Siguiente;
            aux.Siguiente = inicio;
            return aux2;

        }

        public Base eliminar(string nombre)
        {
            if (inicio.Nombre == nombre)
            {
                return eliminarInicio();
            }
            Base aux = inicio;
            while (aux.Siguiente != inicio)
            {
                if (aux.Siguiente.Nombre == nombre)
                {
                    aux.Siguiente = aux.Siguiente.Siguiente;
                }
            }
            return aux.Siguiente;

        }

        public string listar()
        {
            string str = "";
            Base aux = inicio;


            str += aux.String();
            while (aux.Siguiente != inicio)
                {
                    aux = aux.Siguiente;
                    str += aux.String();
                }
            
            return str;
        }
    }
}
