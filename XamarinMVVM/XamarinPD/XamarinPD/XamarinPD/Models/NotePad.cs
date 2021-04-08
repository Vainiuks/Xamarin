using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPD.Models
{
    public class NotePad
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ProductName { get; set; } 
    }
}
