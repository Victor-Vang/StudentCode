using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void FirstOneLastFifteenNotSame()
        {
            // Arrange
            SameFirstLast testObject = new SameFirstLast();

            // Act
            bool result = testObject.IsItTheSame(new int[] { 1, 1, 15 });

            // Assert
            Assert.IsFalse(result);
        }
    }
}
