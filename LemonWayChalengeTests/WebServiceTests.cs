using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonWayChalenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonWayChalenge.Tests
{
    [TestClass()]
    public class WebServiceTests
    {
        [TestMethod()]
        public void FibonacciTest()
        {
            var testFibo = new WebService();
            long res = testFibo.Fibonacci(10);
            Assert.AreEqual(res,55);
        }

        [TestMethod()]
        public void XmlToJsonTest()
        {
            var testJson = new WebService();
            string res = testJson.XmlToJson("<foo>bar</bar>");
            Assert.IsNotNull(res);
        }
    }
}