using Microsoft.VisualBasic;
using System;
using AiEngine.Enums;
using AiEngine.Interfaces;
using AiEngine.Extensions;
using System.Collections;

namespace AiEngine.BitBoard
{
    public class BoardInitializer : IBoardInitializer
    {
        internal UInt64 WhiteKing;
        internal UInt64 WhiteQueens;
        internal UInt64 WhiteRooks;
        internal UInt64 WhiteBishops;
        internal UInt64 WhiteKnights;
        internal UInt64 WhitePawns;
        internal UInt64 WhitePieces;
        /// <summary>
        /// Initialize a bitboard for the given player and piece type
        /// </summary>
        /// <param name="player"></param>
        /// <param name="piece"></param>
        /// <returns></returns>
        public UInt64 InitializeBoard(Player player, Piece piece)
        {
            return InitBoard(player, piece);
        }
        private static UInt64 InitBoard(Player player, Piece piece) {
            UInt64 result = 0;
            var bitArray = result.ToBitArray();
            if(player==0 && piece==0) { //black king
              bitArray[BoardConstants.BlackKing] = true;
            }
             
            return BitConverter.ToUInt64(ConvertToByte(bitArray),0);
        }
        private static byte[] ConvertToByte(BitArray bits) {
            // Make sure we have enough space allocated even when number of bits is not a multiple of 8
            var bytes = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(bytes, 0);
            return bytes;
        }
    }
}