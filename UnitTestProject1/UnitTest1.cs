using System;
using Xunit;

namespace UnitTestProject1
{
    
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var t = new WebApplication1.Controllers.HomeController();
            Assert.Equal(3, t.Add(1, 2));
        }
    }
}
