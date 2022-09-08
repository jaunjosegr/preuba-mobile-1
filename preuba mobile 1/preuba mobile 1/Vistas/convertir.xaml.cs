using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace preuba_mobile_1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class convertir : ContentPage
    {
        double cm;
        double mtrs;
        public convertir()
        {
            InitializeComponent();
        }
        private void calcular()
        {
           cm = Convert.ToDouble(txtcm.Text);
            mtrs = cm / 100;
           resul.Text = mtrs.ToString() + " m"; 
        }
        private void validar()
        {
            if (!String.IsNullOrEmpty(txtcm.Text))
            {
                calcular();
            }
            else
            {
                DisplayAlert("Error", "ingrese una cantidad", "Continuar");
            }
        }
        private void btnvolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void btncal_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}