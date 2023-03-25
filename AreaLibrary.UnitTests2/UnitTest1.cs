using AreaLibrary.Figures;

namespace AreaLibrary.UnitTests2
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void GetArea_ParameterIsDouble_ReturnsArea()
        {
            var circle = new Circle();
            var result = circle.GetArea(new double[] { 2 });
            Assert.AreEqual(Math.PI * 4, result);
        }
        [TestMethod]
        public void GetArea_ParameterIsObject_ReturnsArea()
        {
            var circle = new Circle();
            var result = circle.GetArea(new object[] { new double[] { 2 }});
            Assert.AreEqual(Math.PI * 4, result);
        }
    }
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetArea_ParameterIsDouble_ReturnsArea()
        {
            var triangle = new Triangle();
            var result = triangle.GetArea(new double[] { 3,4,5 });
            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void GetArea_ParameterIsObject_ReturnsArea()
        {
            var triangle = new Triangle();
            var result = triangle.GetArea(new object[] { new double[] { 3,4,5 } });
            Assert.AreEqual(6, result);
        }
    }
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void CalculateArea_SingelParameter_ReturnsArea()
        {
            Assert.AreEqual(6,
            Calculate.CalculateArea(new double[] { 3,4,5 }));
        }
        [TestMethod]
        public void CalculateArea_DoubleParameter_ReturnsArea()
        {
            Assert.AreEqual(Math.PI * 4,
            Calculate.CalculateArea(new double[] { 2 }, "Circle"));
        }
    }
}