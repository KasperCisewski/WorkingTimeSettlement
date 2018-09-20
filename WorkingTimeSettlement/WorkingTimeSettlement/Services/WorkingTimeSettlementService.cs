using System;
using System.Collections.Generic;
using System.Text;
using WorkingTimeSettlement.Models;

namespace WorkingTimeSettlement.Services
{
    public class WorkingTimeSettlementService
    {
        public DayRepository DayRepository { get; set; }
        public DayValidator DayValidator { get; set; }

        public WorkingTimeSettlementService(DayRepository dayRepository, DayValidator dayValidator)
        {
            DayRepository = dayRepository;
            DayValidator = dayValidator;
        }


        public string CheckAndAddToRepository(WorkingDay workingDay)
        {
            throw new NotImplementedException();
        }
    }
}
