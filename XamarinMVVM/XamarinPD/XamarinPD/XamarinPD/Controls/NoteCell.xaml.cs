using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPD.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteCell : ViewCell
    {
        public NoteCell()
        {
            InitializeComponent();
        }
    }
}