using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingTimeSettlement.Models
{
    public class WorkingDay
    {
        public DateTime Date { get; set; }
        public string WorkStart { get; set; }
        public string WorkEnd { get; set; }
        public string BreakAtWork { get; set; }
        public string Description { get; set; }
        
        private string _timeInWork { get;set; }


        public WorkingDay()
        {
            
        }

        public WorkingDay(DateTime date,string workStart,string workEnd,string breakAtWork,string description)
        {
            Date = date;
            WorkStart = workStart;
            WorkEnd = workEnd;
            BreakAtWork = breakAtWork;
            Description = description;
        }
    }
}
