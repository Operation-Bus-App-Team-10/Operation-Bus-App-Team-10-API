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
        [TestMethod]
        public void Can_Create_New_Rating()
        {
            // Arrange
            var rating = new Rating(1, "Mike", "Great fit");

            // Act (empty)

            // Assert
            Assert.AreEqual(1, rating.Stars);
            Assert.AreEqual("Mike", rating.UserName);
            Assert.AreEqual("Great fit!", rating.Review);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Cannot_Create_Rating_With_Invalid_Stars()
        {
            // Arrange
            var rating = new Rating(0, "Mike", "Great fit!");
            
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
