namespace PagarMe.Tests
{
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var c = new Class1();

            Assert.Equal(1, c.Method1());
        }
    }
}
