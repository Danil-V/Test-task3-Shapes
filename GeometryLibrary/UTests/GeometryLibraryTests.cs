using GeometryLibrary.Shapes;
using NUnit.Framework;

namespace GeometryLibrary.UTests
{
    // Юнит-тест с использованием NUnit:
    [TestFixture]
    public class GeometryLibraryTests
    {
        [Test]
        public void CircleAreaCalculation()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(Math.PI * 25, circle.CalculateArea(), 0.001);
        }

        [Test]
        public void TriangleAreaCalculation()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.CalculateArea(), 0.001);
        }

        [Test]
        public void RightTriangleCheck()
        {
            Triangle rightTriangle = new Triangle(3, 4, 5);
            Assert.IsTrue(rightTriangle.IsRightTriangle());

            Triangle nonRightTriangle = new Triangle(1, 2, 3);
            Assert.IsFalse(nonRightTriangle.IsRightTriangle());
        }
    }
}
