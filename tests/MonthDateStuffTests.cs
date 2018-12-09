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
            var result = _monthDateStuff.GetMonthAsInteger();

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
    }
}
