using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaAppDcu
{
    public class ListaContactos: MasterDetailPage
    {
        public ListaContactos()
        {
            var lista = new Listview();

            lista.ItemSource = GeneradorDeContacto.CrearContactos.OrderBy(x => x.Nombre);
            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Detail = new PagContacto(e.SelectedItem as Contacto);
                    IsPresented = false;
                }
            };

            Master = new ContentPage
            {
                Title = "Contactos",
                Content = lista
            };

            Detail = new ContactPage(GeneradorDeContacto.CrearContactos().First());
        }
    }
}
