using dotnet_web_test_action;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Helper.GetHelloWorld();
            Assert.Equal("hello world", res);
        }
    }
}
