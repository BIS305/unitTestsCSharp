using System;
using Xunit;
using ouut;

namespace tests
{
    public class RSATests
    {
        private ouut.RSACSPSample _rsaStuff;

        public RSATests(){
            _rsaStuff = new RSACSPSample();
        }

        [Fact]
        public void ReturnDecrytedStringGivenFilePath(){
            Assert.Equal("Data to Encrypt", _rsaStuff.GetDecrytpedText());
        }
    }
}