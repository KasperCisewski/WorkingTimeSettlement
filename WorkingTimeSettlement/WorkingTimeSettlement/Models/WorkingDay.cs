using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingTimeSettlement.Models
{
    class WorkingDay
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double TimeInWork { get; set; }
        private string TimeInWork { get; set; }
    }
}
