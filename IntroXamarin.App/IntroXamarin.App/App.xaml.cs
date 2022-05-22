using IntroXamarin.App.Views.Forms;
using IntroXamarin.App.Views.NewFolder;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroXamarin.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculadoraPage();
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
