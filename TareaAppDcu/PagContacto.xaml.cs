using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaAppDcu
{
    public partial class PagContacto : ContentPage
    {
        public PagContacto(Contacto contacto)
        {
            InitializeComponent();
            BackGroundColor = Color.FromRgb(48, 63, 159);
            BindingContext = contacto;
        }
    }
}