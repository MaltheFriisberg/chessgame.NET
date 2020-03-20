using System;
using System.Collections;

namespace AiEngine.Extensions {

    public static class IntegerExtension {
        /// <summary>
        /// Extension method for pretty printing a 64 bit integer as a chess board
        /// </summary>
        /// <param name="board"></param>
        public static void PrintBoard(this UInt64 board) {
            byte[] bytes = BitConverter.GetBytes(board);
            var bits = new BitArray(bytes);
        }
    }

}