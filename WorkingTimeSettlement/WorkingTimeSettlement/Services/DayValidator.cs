using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingTimeSettlement.Services
{
    public class DayValidator
    {
        public DayValidator()
        {
          
        }

        public bool IsTimeCorrectlySaved(string time)
        {
            if (time.Split(':').Length == 2)
            {
                string[] probablyHoursAndMinutes = time.Split(':');
                if(ValidateHours(probablyHoursAndMinutes[0]))
                    if (ValidateMinutes(probablyHoursAndMinutes[1]))
                        return true;
            }
            return false;
        }

        private bool ValidateHours(string probablyHours)
        {
            int hours;
            if (int.TryParse(probablyHours, out hours))
            {
                if (hours < 24&&hours>=0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool ValidateMinutes(string probablyMinutes)
        {
            int minutes;
            if(int.TryParse(probablyMinutes,out minutes))
                if (minutes < 60 && minutes >= 0)
                    return true;

            return false;
        }

    }
}
