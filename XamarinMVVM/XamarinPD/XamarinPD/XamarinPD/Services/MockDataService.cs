using System;
using System.Collections.Generic;
using System.Text;
using XamarinPD.Models;

namespace XamarinPD.Services
{
    public class MockDataService : IDataService
    {
        private static List<Product> products = new List<Product>
        {
            new Product()
            {
                ShopName = "Maxima",
                Notes = new List<NotePad>
                {
                     new NotePad { ProductName = "Avokadas"},
                     new NotePad { ProductName = "Citrina"},
                     new NotePad { ProductName = "Jautiena"},
                     new NotePad { ProductName = "Artišokas"},
                     new NotePad { ProductName = "Kinkanas"},
                     new NotePad { ProductName = "Pipirai"},
                     new NotePad { ProductName = "Karpis"},
                     new NotePad { ProductName = "Šokoladas"},
                     new NotePad { ProductName = "Vištiena"}
                }
            },
                new Product()
                {
                     ShopName = "Rimi",
                     Notes = new List<NotePad>{
                          new NotePad { ProductName = "Saldainiai"},
                          new NotePad { ProductName = "Dantų pasta"},
                          new NotePad { ProductName = "Šampūnas"},
                          new NotePad { ProductName = "Dūšo žėlė"},
                          new NotePad { ProductName = "Mašinos kvapukas"},
                          new NotePad { ProductName = "Lego"},
                          new NotePad { ProductName = "Puodelis"},
                          new NotePad { ProductName = "Traškučių"},
                          new NotePad { ProductName = "Ridikėlių"}
                     }
                }

        };


        private static List<Reminder> reminders = new List<Reminder>
        {
            new Reminder()
            {
                ReminderName = "Užsirašyti į kirpyklą",
            },
            new Reminder()
            {
                ReminderName = "Sukurti xamarin aplikaciją",
            },
            new Reminder()
            {
                ReminderName = "Persirašyti windows'us",
            }
        };

        public void AddReminders(Reminder reminder)
        {
            reminders.Add(reminder);
        }
        public IList<Reminder> GetReminders()
        {
            return reminders;
        }
        /// <summary>
        /// /////////////////////
        /// </summary>
        /// <param name="product"></param>

        public void AddProducts(Product product)
        {
            products.Add(product);
        }

        public void DeleteProducts(Product product)
        {
            products.Remove(product);
        }

        public IList<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProducts(Product product)
        {
         //
        }
    }
}
