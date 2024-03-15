using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciarApp_Clicked(object sender, EventArgs e)
        {
            //Abrir una nueva pantalla (Activity = XAML + CS)
            Navigation.PushAsync(new Convertir());
        }
    }
}