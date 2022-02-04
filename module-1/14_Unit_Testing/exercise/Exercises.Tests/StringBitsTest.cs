using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void ResultIsNn()
        {
            // Arrange
            StringBits testObject = new StringBits();

            // Act
            string result = testObject.GetBits("Nani");

            // Assert
            Assert.AreEqual("Nn", result);
        }
    }
}
