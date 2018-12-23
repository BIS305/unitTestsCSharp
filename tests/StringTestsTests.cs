using System;
using Xunit;
using ouut;

namespace tests
{
    public class StringStuffTests
    {
        private ouut.StringStuff _stringStuff;

        public StringStuffTests(){
            _stringStuff = new StringStuff();
        }

        [Theory]
        [InlineData("John Doe")]
        [InlineData("John Mark McFadden")]
        [InlineData("John Jacob Jinglehiemer Smit")]
        public void ReturnFirstNameGivenFullName(string input){
            Assert.Equal("John", _stringStuff.GetFirstNameFromFullName(input));
        }
    }
}