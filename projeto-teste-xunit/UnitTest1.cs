namespace projeto_teste_xunit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        [Fact(Skip = "Teste skip")]
        public void Test2()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(true, true);
        }
    }
}