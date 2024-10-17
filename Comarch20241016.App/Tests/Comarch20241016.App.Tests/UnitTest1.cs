using Comarch20241016.App.CarManager;

namespace Comarch20241016.App.Tests
{
    public class ProgramTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenCalculateAddShouldReturnCorrectValue()
        {
            //Arrange
            int x = 2, y = 3;
            int actual;
            int expected = 5;
            
            //Act
            actual = Program.CalculateAdd(x, y);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        public void TestDostêpnoœci()
        {
            Car car = new Car();
            car.marka = string.Empty;
        }
    }
}