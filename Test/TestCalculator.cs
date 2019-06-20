using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Test

{
    [TestFixture]
    class TestCalculator
    {
        [TestCase(2,2,ExpectedResult =4,Description = "2+2=4")]
        [TestCase(2,-2, ExpectedResult = 0, Description = "2+2=4")]
        [TestCase(-3, -3, ExpectedResult = -6, Description = "-3+(-3)=-6")]
        [TestCase(0, 0, ExpectedResult = 0, Description = "0+0=0")]
        public int testAdd(int a, int b)
        {
            Calculator cal = new Calculator();
            return cal.Add(a, b);
        }

        [TestCase(2, 2, ExpectedResult = 0, Description = "2-2=0")]
        [TestCase(2, -2, ExpectedResult = 4, Description = "2-(-2)=4")]
        [TestCase(-3, 3, ExpectedResult = -6, Description = "-3-3=-6")]
        [TestCase(0, 0, ExpectedResult = 0, Description = "0+0=0")]
        public int testSub(int a, int b)
        {
            Calculator cal = new Calculator();
            return cal.Subtract(a, b);
        }
    }
}
