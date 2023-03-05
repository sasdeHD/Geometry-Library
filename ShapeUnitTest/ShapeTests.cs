using GeometryLibrary.Models;

namespace ShapeUnitTest
{
    [TestFixture]
    public class ShapeTests
    {
        private ShapeCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new ShapeCalculator();
        }

        [Test]
        public void CircleAreaTest()
        {
            var circle = new Circle(2);
            Assert.AreEqual(Math.PI * 4, _calculator.CalculateArea(circle), 0.0001);
        }

        [Test]
        public void TriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, _calculator.CalculateArea(triangle), 0.0001);
        }

        [Test]
        public void TriangleIsRightAngleTest()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

    }
}