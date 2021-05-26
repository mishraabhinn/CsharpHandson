using System;
using Xunit;
using abhinn;

namespace xUnittest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var obj = new Program();
            bool expected = false; 
            //act
            bool actual = obj.isvalid("s1", "s1");
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
