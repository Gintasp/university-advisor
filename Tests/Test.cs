using Xunit;

namespace Advisor.Tests
{
    public class DemoTest
    {
        [Fact]
        public void DemoPassingTest()
        {
            Assert.Equal(4, 2 + 2);
        }
    }
}
