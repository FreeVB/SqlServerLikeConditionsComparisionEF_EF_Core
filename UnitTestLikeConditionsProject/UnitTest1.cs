using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqlClientLikeLibrary;

namespace UnitTestLikeConditionsProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ops = new ClientOperations();
            var dt = ops.GetCustomersWithContains("Fr");
            Assert.IsTrue(dt.Rows.Count == 2, "Expected two for SqlClient test");
        }
    }
}
