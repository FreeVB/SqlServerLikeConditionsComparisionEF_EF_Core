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
        [TestMethod]
        public void StartsEndsTestMethod() 
        {
            var ops = new EntityFrameworkCoreOperations();
            var results = ops.GetCustomersStartWithEndWithLinq("f%d");
            Assert.IsTrue(results.Count == 1, "Expected 1 for EF Core starts and ends with");
        }
        [TestMethod]
        public void BySecondLetterTestMethod()
        {
            var ops = new EntityFrameworkCoreOperations();
            var results = ops.GetCustomersWhereSecondLetterIs("_u%");
            Assert.IsTrue(results.Count == 9, "Expected nine for EF Core starts and ends with");
        }
        [TestMethod]
        public void ByRangeOfNameTestMethod()
        {
            var ops = new EntityFrameworkCoreOperations();
            var results = ops.GetCustomersWhereNameBeginsWithRange("[DA]%");
            foreach (var customerEntity in results)
            {
                Console.WriteLine(customerEntity.CompanyName);
            }
            Assert.IsTrue(results.Count == 7, "Expected 7 for EF Core starts and ends with");
        }
    }
}
