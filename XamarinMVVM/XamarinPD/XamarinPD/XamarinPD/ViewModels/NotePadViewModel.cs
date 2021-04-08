using System;
using System.Collections.Generic;
using System.Text;
using XamarinPD.Models;

namespace XamarinPD.ViewModels
{
    public class NotePadViewModel : BaseViewModel
    {
        public NotePad Data { get; private set; }

        public string Note
        {
            get => Data.ProductName;
            set
            {
                Data.ProductName = value;
                OnPropertyChanged(nameof(Note));
            }
        }
      

        public NotePadViewModel(NotePad note)
        {
            Data = note;

        }
    }
}
