using EntityFramework6LikeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLikeConditionsProject_EF6
{
    [TestClass(), TestCategory("EF 6 code first with existing db")]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ops = new EntityFramework6Operations();
            var results = ops.GetCustomersWithStartWith("Fr");
            Assert.IsTrue(results.Count == 2, "Expected two for EF6 test");
        }
    }
    
}
