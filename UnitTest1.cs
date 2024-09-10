using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCounter;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateTriangleWithWrongParameters()
        {
            //Arrange
            double a = 11;
            double b = 1.2;
            double c = 0.2;
            //Act and Assert
            try
            {
                new Triangle(a, b, c);
                Assert.Fail("Exception not thrown");
            }
            catch (ArgumentOutOfRangeException)
            {
                
            }
        }
        [TestMethod]
        public void CalculateTriangleAreaTest()
        {
            //Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            double area = triangle.Area();
            //Assert
            Assert.IsTrue(area <= 6.0 && area > 5.99);
        }
        [TestMethod]
        public void CheckIfTriangleIsRight()
        {
            //Arrange
            double a = 3.0;
            double b = 4.0;
            double c = 5.0;
            Triangle triangle = new Triangle(a, b, c);
            //Act
            bool testResult = triangle.CheckRightTriangle();
            //Assert
            Assert.IsTrue(testResult);
        }
        [TestMethod]
        public void CalculateCircleAreaTest()
        {
            //Arrange
            double radius = 3.0;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * Math.Pow(3, 2);
            //Act
            double area = circle.Area();
            //Assert
            Assert.AreEqual(expectedArea, area);
        }
    }
}
