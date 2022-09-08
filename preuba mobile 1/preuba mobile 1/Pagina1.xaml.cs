using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using preuba_mobile_1.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace preuba_mobile_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private async void btniniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new convertir());
        }
    }
}