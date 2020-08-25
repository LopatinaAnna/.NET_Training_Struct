using NUnit.Framework;

namespace Struct_1.Tests
{
    public class Tests
    {
        Person person;

        [SetUp]
        public void Setup()
        {
            person = new Person() { Name = "TestName", Surname = "TestSurname", Age = 29 };
        }

        [TestCase(-1)]
        [TestCase(-5)]
        [TestCase(-20)]
        public void CheckAge_InputLessZero_ReturnsCorrectString(int input)
        { 
            // arrange
            int n = input;
            string expectedResult = "Number is less than zero";

            // act
            string actualResult = person.CheckAge(n);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckAge_InputEqualToAge_ReturnsCorrectString()
        {
            // arrange
            int n = 29;
            string expectedResult = $"{person.Name} {person.Surname} is {n}";

            // act
            string actualResult = person.CheckAge(n);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(22)]
        [TestCase(6)]
        [TestCase(10)]
        public void CheckAge_InputSmallerAge_ReturnsCorrectString(int input)
        {
            // arrange
            int n = input;
            string expectedResult = $"{person.Name} {person.Surname} older than {n}";

            // act
            string actualResult = person.CheckAge(n);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(30)]
        [TestCase(56)]
        [TestCase(101)]
        public void CheckAge_InputBiggerAge_ReturnsCorrectString(int input)
        {
            // arrange
            int n = input;
            string expectedResult = $"{person.Name} {person.Surname} younger than {n}";

            // act
            string actualResult = person.CheckAge(n);

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}