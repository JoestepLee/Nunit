using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    class TestTriangle
    {

        Triangle triangle = new Triangle();

        [Test]
        public void TestTypeTriangle()
        {
            Assert.AreEqual(4, triangle.TypeTriangle(2, 2, 3));
        }
        [Test]
        public void TestRightTriangle()
        {
            Assert.AreEqual(1, triangle.IsRightTriangle(3, 4, 5));
        }
    }
}
