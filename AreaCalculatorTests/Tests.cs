using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;
using System;

namespace AreaCalculatorTests
{
    [TestClass]
    public class CircleTests
    {

        [TestMethod]
        public void Circle_WhenRadiusIsLessThanZero_ThrowsException()
        {
            double radius = -7.5;
 
            Circle circle;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => circle = new Circle(radius));
        }

        [TestMethod]
        public void GetArea_WhenRadiusIsValid_ReturnsArea()
        {
            double radius = 10.2;
            double expected = 326.851;

            Circle circle = new Circle(radius);

            Assert.AreEqual(expected, circle.GetArea(), 0.001, "Circle area is not calculated correctly.");
        }
    }

    [TestClass]
    public class TriangleTests
    {

        [TestMethod]
        public void Triangle_WhenSideAIsLessThanZero_ThrowsException()
        {
            double a = -7.5;
            double b = 8.2;
            double c = 3.4;

            Triangle triangle;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => triangle = new Triangle(a, b, c));
        }

        [TestMethod]
        public void Triangle_WhenSideBIsLessThanZero_ThrowsException()
        {
            double a = 7.5;
            double b = -8.2;
            double c = 3.4;

            Triangle triangle;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => triangle = new Triangle(a, b, c));
        }
        [TestMethod]
        public void Triangle_WhenSideCIsLessThanZero_ThrowsException()
        {
            double a = 7.5;
            double b = 8.2;
            double c = -3.4;

            Triangle triangle;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => triangle = new Triangle(a, b, c));
        }

        [TestMethod]
        public void GetArea_WhenSIdesAreValid_ReturnsArea()
        {
            double a = 7.5;
            double b = 8.2;
            double c = 3.4;
            double expected = 12.749;

            Triangle triangle = new Triangle(a, b, c);

            Assert.AreEqual(expected, triangle.GetArea(), 0.001, "Triangle area is not calculated correctly.");
        }

        [TestMethod]
        public void IsRight_WhenTriangleIsRight_ReturnsArea()
        {
            double a = 9;
            double b = 15.58845726812;
            double c = 18;
            var expected = true;

            Triangle triangle = new Triangle(a, b, c);

            Assert.AreEqual(expected, triangle.IsRight(), "Triangle is right-angled, but the method returned false.");
        }

        [TestMethod]
        public void IsRight_WhenTriangleIsNotRight_ReturnsArea()
        {
            double a = 10;
            double b = 17.32;
            double c = 30;
            var expected = false;

            Triangle triangle = new Triangle(a, b, c);

            Assert.AreEqual(expected, triangle.IsRight(), "Triangle is not right-angled, but the method returned true.");
        }
    }
}