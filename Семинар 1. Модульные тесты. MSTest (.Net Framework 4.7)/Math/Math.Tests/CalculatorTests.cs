using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Math.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [DataRow(10, "2", "2", "4")]
        [DataRow(16, "a", "2", "c")]
        [DataRow(2, "1", "1", "10")]
        public void AddTest(int basis, string a, string b, string expectedResult)
        {
            var calculator = new Calculator(basis);
            Assert.AreEqual(expectedResult, calculator.Add(a, b));
        }

        [TestMethod]
        public void DivByZero()
        {
            var calculator = new Calculator(10);
            Assert.ThrowsException<DivideByZeroException>(() => calculator.Div("1", "0"));
        }
    }
}
