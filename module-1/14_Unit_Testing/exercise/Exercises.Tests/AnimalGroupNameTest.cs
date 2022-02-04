using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void SubmitCrocodileReturnFloat()
        {
            // Arrange
            AnimalGroupName testObject = new AnimalGroupName();

            // Act
            string result = testObject.GetHerd("crocodile");

            // Assert
            Assert.AreEqual("Float", result);
        }
    }
}
