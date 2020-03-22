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
        }
    }
}