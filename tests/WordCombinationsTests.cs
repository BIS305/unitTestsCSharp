using System;
using Xunit;
using ouut;

namespace tests
{
    public class WordCombinationsTests
    {
        private ouut.WordCombinations _wordCombos;

        public WordCombinationsTests(){
            _wordCombos = new WordCombinations();
        }

        [Fact]
        public void ReturnWordCombosGivenWordArray(){
            string[] words = {"reAd", "it", "doWnSid3", "UP", "cm19"};
            //Console.WriteLine(_wordCombos.findWords(words));
            Assert.NotEmpty(_wordCombos.findWords(words));
        }
    }
}