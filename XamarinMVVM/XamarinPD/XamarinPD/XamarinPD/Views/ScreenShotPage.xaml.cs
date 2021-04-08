using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScreenShotPage : ContentPage
    {
        public ScreenShotPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Screenshot.IsCaptureSupported)
            {
                var screenshot = await Screenshot.CaptureAsync();
                var stream = await screenshot.OpenReadAsync();
                Screenshotas.Source = ImageSource.FromStream(() => stream);
            }
        }
    }
}