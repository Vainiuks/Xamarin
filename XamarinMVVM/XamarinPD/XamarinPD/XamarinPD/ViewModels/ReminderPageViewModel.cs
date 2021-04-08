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
    public class ReminderPageViewModel
    {

        private IDataService dataService;
        public ObservableCollection<Reminder> Reminders { get; set; }
        public ICommand CreateReminderCommand { get; set; }
        public ICommand OpenReminderCommand { get; set; }


        public ReminderPageViewModel()
        {
            dataService = DependencyService.Get<IDataService>();
            Reminders = new ObservableCollection<Reminder>(dataService.GetReminders());


            CreateReminderCommand = new Command(CreateReminder);

        }



        private void CreateReminder()
        {
            var reminder = new Reminder() { ReminderName = "Užsirašyti" };
            dataService.AddReminders(reminder);
            Reminders.Add(reminder);

        }
   


    }
}
