using System;
using System.Collections.Generic;
using System.Text;
using WorkingTimeSettlement.Models;

namespace WorkingTimeSettlement.Services
{
    public class WorkingTimeSettlementService
    {
        public DayRepository DayRepository { get; set; }
        private DayValidator _dayValidator { get; set; }

        public WorkingTimeSettlementService(DayRepository dayRepository, DayValidator dayValidator)
        {
            DayRepository = dayRepository;
            _dayValidator = dayValidator;
        }


        public string CheckAndAddToRepository(WorkingDay workingDay)
        {
            if (_dayValidator.IsTimeCorrectlySaved(workingDay.WorkStart))          
                if (_dayValidator.IsTimeCorrectlySaved(workingDay.WorkEnd))
                    if (_dayValidator.IsTimeCorrectlySaved(workingDay.BreakAtWork))
                    {
                        DayRepository.SaveDay(workingDay);
                        return $"Everything was all right";
                    }

            return $"Something Was wrong with hours or minutes";
        }
    }
}
