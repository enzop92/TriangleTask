using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTask;

namespace TriangleTaskTest
{
    [TestClass]
    public class RightAngledTriangleTest
    {
        [TestMethod]
        public void IsRightAngledTriangleTest()
        {
            RightAngledTriangle triangle = new RightAngledTriangle(5, 12, 13);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IsNotRightAngledTriangleTest()
        {
            RightAngledTriangle triangle = new RightAngledTriangle(7, 8, 10);         
        }
    }
}
