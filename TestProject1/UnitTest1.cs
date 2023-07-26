using MyTestProject;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = TestProgram.RandomInt();
            Assert.IsTrue(i % 2 == 0);
        }
    }
}