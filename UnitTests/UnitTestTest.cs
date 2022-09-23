using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    // [Collection("Single Test")]
    public class UnitTestTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestTime(int seconds) => Thread.Sleep(seconds * 1000);

        [Fact] public void TestTime1() => Thread.Sleep(1000);
        [Fact] public void TestTime2() => Thread.Sleep(2000);
        [Fact] public void TestTime3() => Thread.Sleep(3000);
        [Fact] public void TestTime4() => Thread.Sleep(4000);

    }
}
