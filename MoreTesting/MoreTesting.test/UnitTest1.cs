namespace MoreTesting.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Random r  = new Random();
            FunctionsForTesting FunTest = new FunctionsForTesting();
            Assert.Equal("hello", FunTest.RandomizeCase("hello", r).ToLower());
        }

        [Theory]
        [InlineData("hello")]
        public void Test2(string n)
        {
            Random r = new Random();
            FunctionsForTesting FunTest = new FunctionsForTesting();
            Assert.Equal(n, FunTest.RandomizeCase(n,r).ToLower());

        }

        [Fact]
        public void Test3()
        {
            FunctionsForTesting FunTest = new FunctionsForTesting();
            Assert.Equal("h\ne\nl\nl\no",FunTest.VerticalString("hello"));
        }
        [Fact]

        public void Test4()
        {
            FunctionsForTesting FunTest = new FunctionsForTesting();
            Assert.Equal("h\ne\nl\nl\no\n\ng\nu\ny\ns\n", FunTest.VerticalString("hello guys "));
        }
            
    }
}
