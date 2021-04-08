using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPD.Services;
using XamarinPD.Views;

namespace XamarinPD
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<MockDataService>();

            InitializeComponent();

            MainPage = new MainPage();
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
