using System.Collections.Generic;
using WorkingTimeSettlement.Models;

namespace WorkingTimeSettlement.Services
{
    public interface IDayRepository
    {

        ICollection<WorkingDay> GetAllWorkingDays();
        WorkingDay GetWorkingDay();
        void ModifyDay(WorkingDay workingDay);
        void SaveDay(WorkingDay workingDay);
    }
}