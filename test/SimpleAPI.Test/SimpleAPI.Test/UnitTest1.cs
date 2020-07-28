using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    [TestClass]
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [TestMethod]
        public void GetReturnMyName()
        {
            var returnValue = controller.Get(1);
            Assert.AreEqual("Nikitha Rajeswaran", returnValue);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
