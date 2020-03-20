using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AiEngine.Extensions;
namespace AiEngine.Tests.Extensions.Tests
{
    [TestClass]
    public class IntegerExtensionTest
    {
        [TestMethod]
        public void TestIntegerExtension() {
            UInt64 test = 0;
            test.PrintBoard();
            Assert.IsFalse(true);
        }
        
    }
}