using System;
using Xunit;
using ouut;

namespace tests
{
    public class MonthDateStuffTests
    {
        private ouut.MonthDateStuff _monthDateStuff;

        public MonthDateStuffTests(){
            _monthDateStuff = new MonthDateStuff();
        }

        [Fact]
        public void ReturnIntegerGivenValidDate()
        {
            var result = _monthDateStuff.GetJanuaryMonthAsInteger();

            Assert.True(result.Equals(1));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void ReturnTrueGivenValidMonthInteger(int monthInt)
        {
            Assert.True(_monthDateStuff.IsValidMonth(monthInt));
        }

        [Theory]
        [InlineData(2018, 12)]
        [InlineData(2019, 1)]
        [InlineData(2019, 3)]
        public void ReturnLastDayOfTheMonth(int year, int month)
        {
            var result = _monthDateStuff.GetLastDayOfTheMonth(year, month);

            Assert.True(result.Equals(31));
        }

        [Fact]
        public void ReturnReviewStartDateGivenCurrent()
        {
            var today = DateTime.Parse("December 2, 2018");
            var result = _monthDateStuff.GetStartDateOfVerseReviewPeriod(today);
            var theDate = DateTime.Parse("December 27, 2018");
            
            Assert.True(result.Equals(theDate));
        }

        [Fact ]
        public void ReturnReviewEndDateGivenCurrent()
        {
            var today = DateTime.Parse("December 2, 2018");
            var result = _monthDateStuff.GetEndDateOfVerseReviewPeriod(today);
            var theDate = DateTime.Parse("December 31, 2018");
            
            Assert.True(result.Equals(theDate));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(15)]
        public void ReturnIsNotCurrentDateInVerseReviewPeriod(int dayOfMonthInteger){
            var today = new DateTime (2019, 1, dayOfMonthInteger, 0, 0, 0);
            var result = _monthDateStuff.IsDateInVerseReviewPeriod(today);
            
            Assert.False(result);
        }

        [Theory]
        [InlineData(27)]
        [InlineData(28)]
        [InlineData(30)]
        public void ReturnIsCurrentDateInVerseReviewPeriod(int dayOfMonthInteger){
            var today = new DateTime (2019, 1, dayOfMonthInteger, 0, 0, 0);
            var result = _monthDateStuff.IsDateInVerseReviewPeriod(today);
            
            Assert.True(result);
        }
    }
}
