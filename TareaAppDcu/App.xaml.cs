using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaAppDcu
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PagContacto(new Contacto
            {
                Nombre = "Hector perez",
                Correo = "Hctp@gmail.com",
                Telefono = "(809) 234 2343"
            });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
