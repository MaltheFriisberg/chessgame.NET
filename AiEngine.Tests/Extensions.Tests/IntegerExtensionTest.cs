using System.Collections;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AiEngine.Extensions;
namespace AiEngine.Tests.Extensions.Tests
{
    [TestClass]
    public class IntegerExtensionTest
    {
        [TestMethod]
        public void TestUint64ToBitArray() {
            UInt64 test = 0; //Setup
            var bitBoard = test.ToBitArray(); //Act
            Assert.IsTrue(bitBoard is BitArray); //Assert
            Assert.AreEqual(bitBoard.Length, 64, 0);
            //Iterate
            for(int i=0; i< bitBoard.Length; i++) {
                //for value zero, all bits are expected to be 0
                Assert.IsFalse(bitBoard[i]);
            }
        }
        [TestMethod]
        public void TestUint64ToString() {
            UInt64 test = 0; //Setup
            var bitBoardString = test.UInt64ToString(); //Act
            Assert.IsTrue(bitBoardString is string); //Assert
            Assert.AreEqual(135, bitBoardString.Length);
        }
        
    }
}