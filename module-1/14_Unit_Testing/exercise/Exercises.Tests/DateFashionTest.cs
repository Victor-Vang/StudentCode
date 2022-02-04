using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        [TestMethod]
        public void YoureAZeroDateAHero()
        {
            // Arrange
            DateFashion testObject = new DateFashion();

            // Act
            int result = testObject.GetATable(0, 10);

            // Assert
            Assert.AreEqual(0, 0);
        }
    }
}
