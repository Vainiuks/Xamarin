using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinPD.Models;
using XamarinPD.Services;

namespace XamarinPD.ViewModels
{
    public class ProductPageViewModel: BaseViewModel
    {

        private IDataService dataService;

        private bool isPresetSelected = false;
        private ProductViewModel selectedProductViewModel;

        public ObservableCollection<ProductViewModel> Products { get; set; }

        public bool IsProductSelected
        {
            get => isPresetSelected;
            set
            {
                isPresetSelected = value;
                OnPropertyChanged(nameof(IsProductSelected));
            }
        }

        public ProductViewModel SelectedProductViewModel
        {
            get => selectedProductViewModel;
            set
            {
                selectedProductViewModel = value;
                OnPropertyChanged(nameof(SelectedProductViewModel));
            }
        }

        public ICommand CreateProductCommand { get; set; }
        public ICommand OpenProductCommand { get; set; }
        public ICommand CloseProductCommand { get; set; }
        public ICommand DeleteProductCommand { get; set; }

        public ProductPageViewModel()
        {
            dataService = DependencyService.Get<IDataService>();
            Products = new ObservableCollection<ProductViewModel>();

            foreach (var p in dataService.GetProducts())
            {
                Products.Add(new ProductViewModel(p));
            }

            CreateProductCommand = new Command(CreateProduct);
            OpenProductCommand = new Command(OpenProduct);
            CloseProductCommand = new Command(CloseProduct);
            DeleteProductCommand = new Command(DeleteProduct);
        }

        private void DeleteProduct()
        {
            Products.Remove(SelectedProductViewModel);
            dataService.DeleteProducts(SelectedProductViewModel.Data);
            CloseProduct();
        }

        private void CreateProduct()
        {
            var product = new Product() { ShopName = "Iki" };
            dataService.AddProducts(product);
            Products.Add(new ProductViewModel(product));

        }
        private void OpenProduct(object obj)
        {
            var target = obj as ProductViewModel;
            IsProductSelected = true;
            SelectedProductViewModel = target;
        }

        private void CloseProduct()
        {
            IsProductSelected = false;
            SelectedProductViewModel = null;
        }


    }
}
