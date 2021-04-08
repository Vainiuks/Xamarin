using System;
using System.Collections.Generic;
using System.Text;
using XamarinPD.Models;

namespace XamarinPD.Services
{
    public interface IDataService
    {
        IList<Product> GetProducts();
        void AddProducts(Product product);
        void DeleteProducts(Product product);
        void UpdateProducts(Product product);


        IList<Reminder> GetReminders();
        void AddReminders(Reminder reminder);

    }
}
