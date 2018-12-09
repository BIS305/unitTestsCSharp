using System;

namespace ouut
{
    public class MonthDateStuff
    {
        public int GetMonthAsInteger()
        {
            var dateInput = "Jan 1, 2019";
            var theDate = DateTime.Parse(dateInput);
            
            return theDate.Month;
        }

        public bool IsValidMonth(int monthInt){
            return monthInt > 0 && monthInt < 13 ;
        }
    }
}
