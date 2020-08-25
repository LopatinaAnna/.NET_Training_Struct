using NUnit.Framework;

namespace Struct_2.Tests
{
    public class Tests
    {
        [TestCase(5, 2, 14)]
        [TestCase(1, 1, 4)]
        [TestCase(1.3, 4.0, 10.6)]
        [TestCase(3.0, 6, 18)]
        [TestCase(5, 2.4, 14.8)]
        public void Perimeter_WithPositiveArguments_ReturnsCorrect(double width, double height, double perimeter)
        {
            // arrange
            Rectangle rectangle = new Rectangle() { Width = width, Height = height };
            double expectedResult = perimeter;

            // act
            double actualResult = rectangle.Perimeter();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 2)]
        [TestCase(0, -1)]
        [TestCase(-3, 10)]
        [TestCase(3.2, 0)]
        [TestCase(0, 0.2)]
        public void Perimeter_WithNegativeArguments_ReturnsZero(double width, double height)
        {
            // arrange
            Rectangle rectangle = new Rectangle() { Width = width, Height = height };
            double expectedResult = 0;

            // act
            double actualResult = rectangle.Perimeter();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}