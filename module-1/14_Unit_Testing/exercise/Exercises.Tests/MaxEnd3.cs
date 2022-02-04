using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]
        public void LargestNumberFifteenMakesAllFifteen()
        {
            // Arrange
            MaxEnd3 testObject = new MaxEnd3();

            // Act
            int[] result = testObject.MakeArray(new int[] { 1, 0, 15});

            // Assert
            CollectionAssert.AreEqual(new int[] { 15, 15, 15 }, result);

        }
    }
}
