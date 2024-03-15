using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloWorld.Vistas;

namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MenuPrincipal();
            //Debemos activar la navegacion
            MainPage = new NavigationPage(new MenuPrincipal());
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
