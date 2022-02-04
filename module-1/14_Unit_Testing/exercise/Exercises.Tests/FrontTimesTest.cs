using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void NanTimesSix()
        {
            // Arrange
            FrontTimes testObject = new FrontTimes();

            // Act
            string result = testObject.GenerateString("Nani", 6);

            // Assert
            Assert.AreEqual("NanNanNanNanNanNan", result);
        }
    }
}
