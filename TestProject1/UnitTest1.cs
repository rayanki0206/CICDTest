namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void DemoTest()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "valus hould be equal to 1");
        }
    }
}