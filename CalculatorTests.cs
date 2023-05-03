using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;

namespace MyMath.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
           
            var calculator = new Calculator();
            int a = 5;
            int b = 3;
            int expected = 8;

            
            int actual = calculator.Add(a, b);

            
            Assert.AreEqual(expected, actual);
        }
    }
}
