using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void StringCountOneEach()
        {
            // Arrange
            WordCount testObject = new WordCount();

            // Act
            Dictionary<string, int> result = testObject.GetCount(new string[]{"N", "a", "n", "i"});

            // Assert
            CollectionAssert.AreEqual(new Dictionary<string, int> { { "N", 1 }, { "a", 1 }, { "n", 1 }, { "i", 1 } }, result);

        }
    }
}
