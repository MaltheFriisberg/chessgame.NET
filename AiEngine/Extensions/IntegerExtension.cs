using System;
using System.Collections;

namespace AiEngine.Extensions {

    public static class IntegerExtension {
        /// <summary>
        /// Extension method for pretty printing a 64 bit integer as a chess board
        /// </summary>
        /// <param name="board"></param>
        public static void PrintBoard(this UInt64 board) {
            Console.WriteLine(board.UInt64ToString());
        }
        public static BitArray ToBitArray(this UInt64 integer){            
            byte[] bytes = BitConverter.GetBytes(integer);
            return new BitArray(bytes);        
        }
        public static string UInt64ToString(this UInt64 integer) {
            string result="";
            var bits = integer.ToBitArray();
            for(int i=0; i<bits.Length; i++) {                
                if(i%8==0 && i!=0) {
                    result+="\n";
                }
                result+=((bits[i] ? 1 : 0)+" ");
            }
            return result;
        }
    }

}