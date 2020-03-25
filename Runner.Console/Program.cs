using Microsoft.VisualBasic;
using System;
using AiEngine;
using AiEngine.Extensions;
using System.Collections;

class Program
    {
        static void Main(string[] args)
        {
            BoardConstants.WhiteRooksBoard.PrintBoard();
           /*UInt64 foo = 0;
           var bitArray = foo.ToBitArray();

           foreach(int pos in BoardConstants.WhitePawns)
            bitArray[pos] = true;

           UInt64 result = BitConverter.ToUInt64(ConvertToByte(bitArray));
           //foo.ToBitArray()[BoardConstants.WhiteKing] = true;
           //foo |= 1 << BoardConstants.WhiteKing;
           result.PrintBoard(); 
           Console.WriteLine(result);*/
        }
        /*static byte[] ConvertToByte(BitArray bits) {
            // Make sure we have enough space allocated even when number of bits is not a multiple of 8
            var bytes = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(bytes, 0);
            return bytes;
        }*/
    }

