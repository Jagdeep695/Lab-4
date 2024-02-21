using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
namespace NUnitDemonstration.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void ValidTriangle_ValidInput_ReturnsValidMessage()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_ReturnsvalidMessage2()
        {
            // Add another test
            // Arrange
            int firstAngle = 45;
            int secondAngle = 45;
            int thirdAngle = 90;
            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        // Add more test methods as needed to cover different scenarios
        [Test]
      
        public void ValidTriangle_ValidInput_Scalene_ReturnsValidMessage3()
        {
            // Arrange
            int firstAngle = 30;
            int secondAngle = 60;
            int thirdAngle = 90;

            // Act
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_ZeroAngle_ReturnsInvalidMessage4()
        {
            int firstAngle = 90;
            int secondAngle = 45;
            int thirdAngle = 0;
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        [Test]
        public void ValidTriangle_ValidInput_MaximumValues_ReturnsValidMessage5()
        {
            int firstAngle = 89;
            int secondAngle = 45;
            int thirdAngle = 46;
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_SumNotEqual180Degrees_ReturnsInvalidMessage6()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 70;
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_AllZeroAngles_ReturnsInvalidMessage7()
        {
            int firstAngle = 0;
            int secondAngle = 0;
            int thirdAngle = 0;
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual("The triangle is NOT valid.", result);
        }
        [Test]
        public void ValidTriangle_AcuteAngledIsosceles_ReturnsValidMessage8()
        {
            int firstAngle = 40;
            int secondAngle = 70;
            int thirdAngle = 70;
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_ObtuseAngledIsosceles_ReturnsValidMessage9()
        {
            int firstAngle = 80;
            int secondAngle = 50;
            int thirdAngle = 50;
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_ScaleneWithMaximumValues_ReturnsValidMessage10()
        {
            int firstAngle = 60;
            int secondAngle = 70;
            int thirdAngle = 50;
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual("The triangle is valid.", result);
        }
        [Test]
        public void ValidTriangle_InvalidInput_SumGreaterThan180Degrees_ReturnsInvalidMessage11()
        {
            int firstAngle = 90;
            int secondAngle = 95;
            int thirdAngle = 10;
            string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual("The triangle is NOT valid.", result);
        }

    }
}























