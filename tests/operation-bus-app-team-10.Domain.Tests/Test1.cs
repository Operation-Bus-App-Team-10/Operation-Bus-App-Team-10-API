using Microsoft.VisualStudio.TestTools.UnitTesting;
using operation-bus-app-team-10.Domain;

namespace operation-bus-app-team-10.Domain.Tests
{
    [TestClass]
    public class RatingTests
    {
        [TestMethod]
        public void CreateRating_ValidStars_CreatesSuccessfully()
        {
            // Arrange
            int validStars = 5;

            // Act
            var rating = new Rating(validStars);

            // Assert
            Assert.AreEqual(validStars, rating.Stars);
        }
    }
    [TestMethod]
[ExpectedException(typeof(ArgumentException))]
public void CreateRating_InvalidStars_ThrowsException()
{
    // Arrange
    int invalidStars = -1;

    // Act
    var rating = new Rating(invalidStars);
}
}
