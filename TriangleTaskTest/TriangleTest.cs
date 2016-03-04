using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTask;

namespace TriangleTaskTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void getAreaTest()
        {
            Triangle triangle = new Triangle(5, 12, 13);
            Assert.AreEqual((5 * 12) / 2, triangle.getArea());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WrongSidesTest()
        {
            Triangle triangle = new Triangle(5, 0, 12);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InequalityTriangleTest()
        {
            Triangle triangle = new Triangle(5, 5, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InequalityTriangleTest2()
        {
            Triangle triangle = new Triangle(2, 8, 6);
        }
    }
}
