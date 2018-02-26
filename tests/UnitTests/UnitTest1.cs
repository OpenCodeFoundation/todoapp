using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Trait("Category", "UnitTest")]
        [Fact]
        public void Test1()
        {
            Assert.Equal(2, 2);
        }
    }
}
