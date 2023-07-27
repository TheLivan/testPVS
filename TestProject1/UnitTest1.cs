using MyTestProject;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(TestProgram.RandomInt() % 2 == 0);
        }
    }
}