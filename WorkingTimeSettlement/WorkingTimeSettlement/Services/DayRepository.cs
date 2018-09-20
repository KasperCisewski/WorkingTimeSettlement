using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;
using WorkingTimeSettlement.Models;
using Xamarin.Forms;

namespace WorkingTimeSettlement.Services
{
    public class DayRepository : IDayRepository
    {

        private SQLiteConnection database;

        private static object locker = new object();

        public DayRepository()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<WorkingDay>();
        }

        public void SaveDay(WorkingDay workingDay)
        {

        }

        public void ModifyDay(WorkingDay workingDay)
        {

        }

        public WorkingDay GetWorkingDay()
        {
            throw new NotImplementedException();
        }

        public ICollection<WorkingDay> GetAllWorkingDays()
        {
            throw new NotImplementedException();
        }
    }
}
