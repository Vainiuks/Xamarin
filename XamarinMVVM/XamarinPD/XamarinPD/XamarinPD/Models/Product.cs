using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPD.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ShopName { get; set; }
        public List<NotePad> Notes { get; set; } = new List<NotePad>();
    }
}
