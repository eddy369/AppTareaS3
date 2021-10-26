using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTareaS3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //se habilita la navegacion entre ventanas
            MainPage = new NavigationPage(new MainPage());
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
