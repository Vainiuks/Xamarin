using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPD.Models;
using XamarinPD.Views;

namespace XamarinPD.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public static List<ProductViewModel> FromRange(IEnumerable<Product> products)
        {
            var result = new List<ProductViewModel>();
            foreach (var product in products)
            {
                result.Add(new ProductViewModel(product));
            }

            return result;
        }

        public Product Data { get; private set; }
        public string ShopName
        {
            get => Data.ShopName;
            set
            {
                Data.ShopName = value;
                OnPropertyChanged(nameof(ShopName));
            }
        }
        public ObservableCollection<NotePadViewModel> Notes { get; set; }
        public ICommand CreateNoteCommand { get; set; }
        public ICommand DeleteNoteCommand { get; set; }

        public ProductViewModel(Product target)
        {
            Data = target;
            Notes = new ObservableCollection<NotePadViewModel>();
            foreach (var i in Data.Notes)
            {
                Notes.Add(new NotePadViewModel(i));
            }

            CreateNoteCommand = new Command(CreateNote);
            DeleteNoteCommand = new Command(DeleteNote);
        }

        public void CreateNote()
        {
            var note = new NotePad() { ProductName = "Pomidorai" };
            Notes.Add(new NotePadViewModel(note));
            Data.Notes.Add(note);
        }

        public void DeleteNote(object obj)
        {
            var target = obj as NotePadViewModel;
            Notes.Remove(target);
            Data.Notes.Remove(target.Data);
        }



    }
}
