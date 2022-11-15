namespace Refactoring.UnitTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Refactoring;
    using Refactoring.Shapes;

    [TestClass]
    public class UnitTest
    {
        private const double TriangleHeight = 13d;
        private const double TriangleWidth = 34d;
        private const double TriangleSurfaceArea = 221d;
        private const double CircleRadius = 23d;
        private const double CircleSurfaceArea = 1661.9d;
        private const double SquareSide = 17d;
        private const double SquareSurfaceArea = 289d;
        private const double RectangleHeight = 23d;
        private const double RectangleWidth = 67d;
        private const double RectangleSurfaceArea = 1541d;
        private const double TrapezoidBase1 = 10d;
        private const double TrapezoidBase2 = 15d;
        private const double TrapezoidHeight = 4d;
        private const double TrapezoidSurfaceArea = 50d;

        [TestMethod]
        public void TriangleCalculateSurfaceArea()
        {
            // Arrange
            var triangle = new Triangle(TriangleHeight, TriangleWidth);

            // Act
            double surfaceArea = triangle.CalculateSurfaceArea();

            // Assert
            Assert.AreEqual(TriangleSurfaceArea, surfaceArea);
        }

        [TestMethod]
        public void CircleCalculateSurfaceArea()
        {
            // Arrange
            var circle = new Circle(CircleRadius);

            // Act
            double surfaceArea = circle.CalculateSurfaceArea();

            // Assert
            Assert.AreEqual(CircleSurfaceArea, surfaceArea);
        }

        [TestMethod]
        public void SquareCalculateSurfaceArea()
        {
            // Arrange
            var square = new Square(SquareSide);

            // Act
            double surfaceArea = square.CalculateSurfaceArea();

            // Assert
            Assert.AreEqual(SquareSurfaceArea, surfaceArea);
        }

        [TestMethod]
        public void RectangleCalculateSurfaceArea()
        {
            // Arrange
            var rectangle = new Rectangle(RectangleHeight, RectangleWidth);

            // Act
            double surfaceArea = rectangle.CalculateSurfaceArea();

            // Assert
            Assert.AreEqual(RectangleSurfaceArea, surfaceArea);
        }
        [TestMethod]
        public void TrapezoidCalculateSurfaceArea()
        {
            // Arrange
            var trapezoid = new Trapezoid(TrapezoidBase1, TrapezoidBase2, TrapezoidHeight);

            // Act
            double surfaceArea = trapezoid.CalculateSurfaceArea();

            // Assert
            Assert.AreEqual(TrapezoidSurfaceArea, surfaceArea);
        }

        [TestMethod]
        public void CalculateSurfaceAreas()
        {
            // Arrange
            var triangle = new Triangle(TriangleHeight, TriangleWidth);

            var circle = new Circle(CircleRadius);

            var square = new Square(SquareSide);

            var rectangle = new Rectangle(RectangleHeight, RectangleWidth);

            var trapezoid = new Trapezoid(TrapezoidBase1, TrapezoidBase2, TrapezoidHeight);

            double[] expectedSurfaceAreas = new double[] { TriangleSurfaceArea, CircleSurfaceArea, SquareSurfaceArea, RectangleSurfaceArea, TrapezoidSurfaceArea };

            // Act
            SurfaceAreaCalculator surfaceAreaCalculator = new SurfaceAreaCalculator();
            surfaceAreaCalculator.AddShape(triangle);
            surfaceAreaCalculator.AddShape(circle);
            surfaceAreaCalculator.AddShape(square);
            surfaceAreaCalculator.AddShape(rectangle);
            surfaceAreaCalculator.AddShape(trapezoid);
            double[] surfaceAreas = surfaceAreaCalculator.CalculateSurfaceAreas().ToArray();

            // Assert
            Assert.AreEqual(expectedSurfaceAreas[0], surfaceAreas[0]);
            Assert.AreEqual(expectedSurfaceAreas[1], surfaceAreas[1]);
            Assert.AreEqual(expectedSurfaceAreas[2], surfaceAreas[2]);
            Assert.AreEqual(expectedSurfaceAreas[3], surfaceAreas[3]);
            Assert.AreEqual(expectedSurfaceAreas[4], surfaceAreas[4]);
        }
    }
}
