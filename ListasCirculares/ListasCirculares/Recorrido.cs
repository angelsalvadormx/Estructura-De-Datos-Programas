using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares
{
    class Recorrido
    {
        private Base inicio;

        public void agregarFinal(Base recibida)
        {
            if(inicio == null)
            {
                inicio = recibida;
                inicio.Siguiente = inicio;
            }
            else
            {
                Base aux = inicio;
                while(aux.Siguiente != inicio)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = recibida;
                aux.Siguiente.Siguiente = inicio;
            }
        }
        public Base buscar(string nombre)
        {
            Base aux = inicio;
            if(aux.Nombre == nombre)
            {
                return aux;
            }
            aux = aux.Siguiente;
            while(aux != inicio)
            {
                if(aux.Nombre == nombre)
                {
                    return aux;
                }
                aux = aux.Siguiente;
            }
            return null;
        }
        public Base eliminarUltimo()
        {
            if (inicio.Siguiente == inicio)
            {
                Base aux3 = inicio;
                inicio = null;
                return aux3;
            }
            Base aux = inicio;
            while(aux.Siguiente.Siguiente != inicio)
            {
                aux = aux.Siguiente;
            }
            Base aux2 = aux.Siguiente;
            aux.Siguiente = inicio;
            return aux2;

        }
        public Base eliminarInicio()
        {
            Base aux = inicio;
            Base aux2 = inicio;
            while(aux.Siguiente != inicio)
            {
                aux = aux.Siguiente;
            }
            inicio = inicio.Siguiente;
            aux.Siguiente = inicio;
            return aux2;

        }
        public Base eliminar(string nombre)
        {
            if(inicio.Nombre == nombre)
            {
                return eliminarInicio();
            }
            Base aux = inicio;
            while(aux.Siguiente != inicio)
            {
                if(aux.Siguiente.Nombre == nombre)
                {
                    Console.WriteLine("Eliminado");
                    aux.Siguiente = aux.Siguiente.Siguiente;
                }
            }
            return aux.Siguiente;

        }
        public string listar()
        {
            string str = "";
            Base aux = inicio;
            str += aux.ToString();
            while(aux.Siguiente != inicio)
            {
                aux = aux.Siguiente;
                str += aux.ToString();
            }
            return str;
        }

        public string ruta(string base_inicio, string hora_inicio, string hora_fin)
        {
            TimeSpan horaInicio = TimeSpan.Parse(hora_inicio);
            TimeSpan horaFin = TimeSpan.Parse(hora_fin);
            string str = "";
            TimeSpan tiempo = horaFin - horaInicio;
            TimeSpan contador = TimeSpan.Parse("00:00:00");
            Base comienzo = inicio;
            //While para comenzar desde la base indicada
            
            while(comienzo.Nombre != base_inicio)
            {
                comienzo = comienzo.Siguiente;
            }
            /*
            do {
                TimeSpan convertidor = TimeSpan.FromMinutes(Convert.ToInt64(comienzo.Duracion));
     
                    contador += convertidor;
                    str += comienzo.Nombre + " - " + contador + "/";
                    comienzo = comienzo.Siguiente;
                
            } while (contador<tiempo);
            */
            contador = horaInicio;
            while (contador < (tiempo+horaInicio))
            {
                str += comienzo.Nombre + " - " + contador + "/";
                TimeSpan convertidor = TimeSpan.FromMinutes(Convert.ToInt64(comienzo.Duracion));
                contador = contador + convertidor;
                comienzo = comienzo.Siguiente;
               
            }            
            return "Desde base: "+ base_inicio +" Hora de inicio: "+ horaInicio.ToString() +
            " Hora de fin: "+horaFin.ToString() +" Duración del recorrido: "+ tiempo.ToString() +
            Environment.NewLine + Environment.NewLine + str + Environment.NewLine; 
        }
        public void insertar(Base nuevo, int pos)
        {
            Base aux = inicio;
            if(pos == 1)
            {
                Base aux2 = nuevo;
                aux2.Siguiente = inicio;
                inicio = aux2;
                Base aux3 = inicio;
                while(aux3.Siguiente.Siguiente != aux)
                {
                    aux3 = aux3.Siguiente;
                }
                aux3.Siguiente.Siguiente = inicio;
            }
            else
            {
                Base aux3 = inicio;
                for(int i = 1; i < (pos - 1); i++)
                {
                    aux3 = aux3.Siguiente;
                }
                Base aux4 = aux3.Siguiente;
                aux3.Siguiente = nuevo;
                aux3.Siguiente.Siguiente = aux4;
            }
        }
    }
}
