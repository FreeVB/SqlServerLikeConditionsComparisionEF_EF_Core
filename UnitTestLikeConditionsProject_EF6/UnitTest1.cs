using EntityFramework6LikeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLikeConditionsProject_EF6
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ops = new EntityFramework6Operations();
            var results = ops.GetCustomersWithContains("Fr");
            Assert.IsTrue(results.Count == 2, "Expected two for EF6 test");
        }
    }
}
