using System;
using EntityFrameworkCoreLikeLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLikeConditionsEF_CoreProject
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ops = new EntityFrameworkCoreOperations();
            var results = ops.GetCustomersStartsWithLambda("Fr%");
            Assert.IsTrue(results.Count == 2, "Expected two for EF Core test");

            results = ops.GetCustomersStartWithLinq("Fr%");
            Assert.IsTrue(results.Count == 2, "Expected two for EF Core test");
        }
    }
}
