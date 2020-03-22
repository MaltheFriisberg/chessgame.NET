using Microsoft.VisualBasic;
using System;
using AiEngine.Enums;
using AiEngine.Interfaces;
using AiEngine.Extensions;

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
        private UInt64 InitBoard(Player player, Piece piece) {
            UInt64 result = 0;
            if(player==0 && piece==0) { //black king
              var bitArray = result.ToBitArray();
              //bitArray[BoardConstants.BlackKing]
            }
             
            return result;
        }
    }
}