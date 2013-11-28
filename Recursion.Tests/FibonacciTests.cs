using System;
using System.Linq;
using NUnit.Framework;
using Recursion.BLL;

namespace Recursion.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void FibonacciLogicReturnsProperOutput()
        {
            var fs = new FibonacciSevice();
            Assert.AreEqual(1,fs.GetFibonacciNumber(1));
            Assert.AreEqual(2, fs.GetFibonacciNumber(3));
            Assert.AreEqual(5, fs.GetFibonacciNumber(5));
            Assert.AreEqual(55, fs.GetFibonacciNumber(10));
        }

        [Test]
        public static void FibonacciStaticServiceReturnsCorrectOutput()
        {
            Assert.AreEqual(1, FibonacciSevice.GetFibonacciNumberStatic(1));
            Assert.AreEqual(2, FibonacciSevice.GetFibonacciNumberStatic(3));
            Assert.AreEqual(5, FibonacciSevice.GetFibonacciNumberStatic(5));
            Assert.AreEqual(55, FibonacciSevice.GetFibonacciNumberStatic(10));
        }
    }
}
