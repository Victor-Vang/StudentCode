using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void ArrayWithOneAndFive()
        {
            // Arrange
            Lucky13 testObject = new Lucky13();

            // Act
            bool result = testObject.GetLucky(new int[] { 1, 5 });

            // Assert
            Assert.IsFalse(result);
        }
    }
}
