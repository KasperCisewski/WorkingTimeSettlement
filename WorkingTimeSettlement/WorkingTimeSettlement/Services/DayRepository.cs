using System;
using System.Collections.Generic;
using System.Text;
using WorkingTimeSettlement.Models;

namespace WorkingTimeSettlement.Services
{
    public class DayRepository
    {
        public string FilePath { get; set; }

        public DayRepository(string filePath)
        {
            FilePath = filePath;
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
