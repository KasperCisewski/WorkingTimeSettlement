using System;
using System.Collections.Generic;
using System.Text;
using WorkingTimeSettlement.Models;
using WorkingTimeSettlement.Services;

namespace WorkingTimeSettlement.ViewModels
{
    public class AddOtherDayViewModel
    {   
        public DateTime MinimalDate { get; set; }
        public DateTime MaximalDate { get; set; }
        public DateTime SelectedDate { get; set; }
        public string MessageForUser { get; set; }

        public AddOtherDayViewModel()
        {
            MessageForUser = "";
            SelectedDate = DateTime.Today;
            MinimalDate = new DateTime(SelectedDate.Year-1,SelectedDate.Month,SelectedDate.Day);
            MaximalDate = new DateTime(SelectedDate.Year+1, SelectedDate.Month, SelectedDate.Day);
        }

        public void TryToSaveWorkingTimeToRepository(object sender)
        {
            WorkingDay workingDay;
            try
            {
                 workingDay = (WorkingDay) sender;
            }
            catch (Exception e)
            {
                MessageForUser = "Something was wrong";
                Console.WriteLine(e);
                throw;
            }

            MessageForUser = App.SettlementService.DayValidator;

        }
    }
}
