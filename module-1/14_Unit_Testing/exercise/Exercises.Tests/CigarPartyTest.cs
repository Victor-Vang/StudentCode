using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void NotEnoughCigarsNotTheWeekend()
        {
            // Arrange
            CigarParty testObject = new CigarParty();

            // Act
            bool result = testObject.HaveParty(30, false);

            // Assert
            Assert.IsFalse(result);

        }
    }
}
