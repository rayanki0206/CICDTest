using System.Numerics;
using WebApplication1.Modules;

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
            Assert.True(result, "valus should be equal to 1");
        }

        [Test]
        public void CheckAddFunction()
        {
            Functions fn= new Functions();
            int y = fn.Add(5, 5);
            bool result = false;
            if(y== 10) result = true;
            Assert.True(result, "value should be equa; to 10");
        }
    }
}