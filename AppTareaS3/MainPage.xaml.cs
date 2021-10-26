using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTareaS3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //almacenar los datos en variables
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (txtUsuario.Text == "estudiante2021" && txtContrasena.Text == "uisrael2021")
            {
                //accion navegar a ventana dos
                await Navigation.PushAsync(new viewDos());
            }
            else
            {
                DisplayAlert("Ups", "Usuario o Contrasena Incorrecto", "OK");
            }
        }
    }
}
