using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPD.Models
{
    public class Reminder
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ReminderName { get; set; }
    }
}
