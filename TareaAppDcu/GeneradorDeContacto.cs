using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace TareaAppDcu
{
    internal class GeneradorDeContacto
    {
        private static List<string> ListaNombres = new List<string>
        {
            "Juan", "Pedro", "Gustavo", "Rodolfo",
            "Manuel", "Cristina", "Regina", "Georgina",
            "Manuela"
        };

        private static List<string> ListaApellidos = new List<string>
        {
            "Gonzales", "Pastrana", "Perez", "Lopez",
            "Trinidad", "Mendez", "Allende", "Escobar",
            "Sanchez"
        };

        public static ObservableCollection<Contacto> CrearContactos()
        {
            var random = new Random();
            var contactos = new ObservableCollection<Contacto>();
            for (int i = 0; i < 25; i++)
            {
                var nombre = ListaNombres[random.Next(ListaNombres.Count - 1)];
                var apellido = ListaApellidos[random.Next(ListaApellidos.Count - 1)];

                var contacto = new Contacto
                {
                    Nombre = nombre + " " + apellido,
                    Telefono = GenerarTelefono(),
                    Correo = nombre + apellido + "@itla.edu.do"
                };
                contactos.Add(contacto);
            }
            return contactos;
        }

        private static string GenerarTelefono()
        {
            var random = new Random();
            StringBuilder telefono = new StringBuilder();
            telefono.Append("(");
            telefono.Append(random.Next(100, 999));
            telefono.Append(random.Next(1000000, 9999999));

            return telefono.ToString();
        }
    }
}
