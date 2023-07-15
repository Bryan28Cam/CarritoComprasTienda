using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarritoComprasTienda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public string WebAPIkey = "AIzaSyCHlzpOWy5aSy0i0Aw5HlAcCDLIBvR6eIQ";
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {

        }

        async void btnRegistrar_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(txtNuevoUsuario.Text, txtNuevaContraseña.Text);
                string gettoken = auth.FirebaseToken;
                await App.Current.MainPage.DisplayAlert("Alert", gettoken, "Ok");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }

        }
    }
}