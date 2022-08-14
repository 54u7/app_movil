using System;
using System.Collections.Generic;
using System.Text;

namespace TareaAppDcu
{
    internal class Contacto
    {
        private string _nombre;
        private string _telefono;
        private string _Correo;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }


        public override string toString()
        {
            return Nombre;
        }
    }
}
