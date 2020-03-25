using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace AiEngine.Tests.ConstantsTests
{
    [TestClass]
    public class ConstantsTests
    {
        [TestMethod]
        public void TestBlackConstants() {
            Assert.AreEqual(3, BoardConstants.BlackKing);
            Assert.AreEqual(4, BoardConstants.BlackQueen);
            Assert.AreEqual(0, BoardConstants.BlackRooks[0]);
            Assert.AreEqual(7, BoardConstants.BlackRooks[1]);
            Assert.AreEqual(2, BoardConstants.BlackBishops[0]);
            Assert.AreEqual(5, BoardConstants.BlackBishops[1]);
            Assert.AreEqual(1, BoardConstants.BlackKnights[0]);
            Assert.AreEqual(6, BoardConstants.BlackKnights[1]);
            Assert.AreEqual(92, BoardConstants.BlackPawns.Sum());

            Assert.AreEqual((UInt64)8, BoardConstants.BlackKingBoard);
            Assert.AreEqual((UInt64)16, BoardConstants.BlackQueenBoard);
            Assert.AreEqual((UInt64)129, BoardConstants.BlackRooksBoard);
            Assert.AreEqual((UInt64)36, BoardConstants.BlackBishopsBoard);
            Assert.AreEqual((UInt64)66, BoardConstants.BlackKnightsBoard);
            Assert.AreEqual((UInt64)65280, BoardConstants.BlackPawnsBoard);

        }
        [TestMethod]
        public void TestWhiteConstants() {
            Assert.AreEqual(59, BoardConstants.WhiteKing);
            Assert.AreEqual(60, BoardConstants.WhiteQueen);
            Assert.AreEqual(56, BoardConstants.WhiteRooks[0]);
            Assert.AreEqual(63, BoardConstants.WhiteRooks[1]);
            Assert.AreEqual(58, BoardConstants.WhiteBishops[0]);
            Assert.AreEqual(61, BoardConstants.WhiteBishops[1]);
            Assert.AreEqual(57, BoardConstants.WhiteKnights[0]);
            Assert.AreEqual(62, BoardConstants.WhiteKnights[1]);
            Assert.AreEqual(412, BoardConstants.WhitePawns.Sum());

            Assert.AreEqual((UInt64)576460752303423488, BoardConstants.WhiteKingBoard);
            Assert.AreEqual((UInt64)1152921504606846976, BoardConstants.WhiteQueenBoard);
            Assert.AreEqual((UInt64)2594073385365405696, BoardConstants.WhiteBishopsBoard);
            Assert.AreEqual((UInt64)9295429630892703744, BoardConstants.WhiteRooksBoard);
            Assert.AreEqual((UInt64)4755801206503243776, BoardConstants.WhiteKnightsBoard);
            Assert.AreEqual((UInt64)71776119061217280, BoardConstants.WhitePawnsBoard);
            
            
        }        
    }
}