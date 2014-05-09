using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestBox
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(mybox);
        }
    }
}
