using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPD.ViewModels;

namespace XamarinPD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReminderPage : ContentPage
    {
        public ReminderPage()
        {
            BindingContext = new ReminderPageViewModel();
            InitializeComponent();
        }
    }
}