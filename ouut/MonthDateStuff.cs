using System;

//ouut (Object Under Unit Test)
namespace ouut
{
    public class MonthDateStuff
    {
        public int GetJanuaryMonthAsInteger()
        {
            var theDate = DateTime.Parse("Jan 1, 2019");
            
            return theDate.Month;
        }

        public bool IsValidMonth(int monthInt){
            return monthInt > 0 && monthInt < 13 ;
        }

        public int GetLastDayOfTheMonth(int year, int month){
            return DateTime.DaysInMonth(year, month);
        }

        public DateTime GetStartDateOfVerseReviewPeriod(DateTime today){
            DateTime lastDayOfMonthDate = new DateTime (today.Year, today.Month,
                                    DateTime.DaysInMonth(today.Year, today.Month));
            var result = lastDayOfMonthDate.AddDays(-4);
            return result;
        }

        public DateTime GetEndDateOfVerseReviewPeriod(DateTime today){
            DateTime lastDayOfMonthDate = new DateTime (today.Year, today.Month,
                                    DateTime.DaysInMonth(today.Year, today.Month));
            return lastDayOfMonthDate;
        }

        public bool IsDateInVerseReviewPeriod(DateTime today){
            var startDate = GetStartDateOfVerseReviewPeriod(today);
            var endDate = GetEndDateOfVerseReviewPeriod(today);
            return today >= startDate && today <= endDate;
        }
    }
}
