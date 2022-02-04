using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void ConcatEeHarp()
        {
            // Arrange
            NonStart testObject = new NonStart();

            // Act
            string result = testObject.GetPartialString("See", "Sharp");

            // Assert
            Assert.AreEqual("eeharp", result);
        }
    }
}
