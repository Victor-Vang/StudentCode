using Assessment.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assessment.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ActualCostWithRushAndIce()
        {
            WorkOrder testObject = new WorkOrder("Victor", 15, 15);

            decimal result = testObject.ActualTotal(true, true);

            Assert.AreEqual(69.94M, result);
        }
        
        [TestMethod]
        public void ToStringTest()
        {
            WorkOrder testObject = new WorkOrder("Victor", 15, 15);

            string result = testObject.ToString();

            Assert.AreEqual("WORK ORDER - Victor - 11.23", result);
        }
    }
}
