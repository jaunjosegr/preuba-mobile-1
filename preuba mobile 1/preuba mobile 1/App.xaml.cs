﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using preuba_mobile_1.Vistas;

namespace preuba_mobile_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Pagina1());
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
