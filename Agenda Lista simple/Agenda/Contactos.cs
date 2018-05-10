using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contactos
    {
        private
        string _nombre;
        string _apPaterno;
        string _apMaterno;
        string _correo;
        long _telefono;
        int _edad;
        Contactos _siguiente;

        public Contactos Siguiente{
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public string Nombre{
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string ApellidoPaterno{
            get { return _apPaterno; }
            set { _apPaterno = value; }
        }
        public string ApellidoMaterno{
            get { return _apMaterno; }
            set { _apMaterno = value; }
        }
        public string Correo{
            get { return _correo; }
            set { _correo = value; }    
        }
        public long Telefono {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public int Edad {
            get { return _edad; }
            set { _edad = value; }
        }

        public string String()
        {
            return "Nombre: " + _nombre + Environment.NewLine + "Apellido parterno: "+ _apPaterno +Environment.NewLine +"Apellido Materno:"+ _apMaterno + Environment.NewLine +"Correo:"+ _correo +Environment.NewLine +"Edad:"+ _edad +Environment.NewLine+"Telefono"+ Telefono+ Environment.NewLine;
        }
    }
}
