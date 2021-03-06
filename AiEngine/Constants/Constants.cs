using System;
using System.Collections;
using AiEngine.Extensions;

namespace AiEngine
{
    /// <summary>
    /// 0 1 2 3 4 5 6 7
    /// 8 9 10 11 12 13 14 15
    /// 16 17 18 19 20 21 22 23
    /// 24 25 26 27 28 29 30 31
    /// 32 33 34 35 36 37 38 39
    /// 40 41 42 43 44 45 46 47
    /// 48 49 50 51 52 53 54 55
    /// 56 57 58 59 60 61 62 63
    /// </summary>
    public static class BoardConstants
    {
        //Black - positioned Top
        public static int BlackKing = 3;
        public static int BlackQueen = 4;
        public static int[] BlackRooks = new int[]{0,7}; //Tower
        public static int[] BlackBishops = new int[]{2,5};
        public static int[] BlackKnights = new int[]{1,6};
        public static int[] BlackPawns = new int[]{8,9,10,11,12,13,14,15};
        //White - positioned Bottom
        public static int WhiteKing = 59;
        public static int WhiteQueen = 60;
        public static int[] WhiteRooks = new int[]{56,63}; //Tower
        public static int[] WhiteBishops = new int[]{58,61};
        public static int[] WhiteKnights = new int[]{57,62};
        public static int[] WhitePawns = new int[]{48,49,50,51,52,53,54,55};

        //Computed integer values for initial bitboard states
        //Black
        public static UInt64 BlackKingBoard = 8;
        public static UInt64 BlackQueenBoard = 16;
        public static UInt64 BlackRooksBoard = 129;
        public static UInt64 BlackBishopsBoard = 36;
        public static UInt64 BlackKnightsBoard = 66;
        public static UInt64 BlackPawnsBoard = 65280;
        //White
        public static UInt64 WhiteKingBoard = 576460752303423488;
        public static UInt64 WhiteQueenBoard = 1152921504606846976;
        public static UInt64 WhiteRooksBoard = 9295429630892703744;
        public static UInt64 WhiteBishopsBoard = 2594073385365405696;
        public static UInt64 WhiteKnightsBoard = 4755801206503243776;
        public static UInt64 WhitePawnsBoard =  71776119061217280;
        
    }
}