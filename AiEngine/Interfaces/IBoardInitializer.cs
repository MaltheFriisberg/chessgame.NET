using System;
using AiEngine.Enums;

namespace AiEngine.Interfaces
{
    public interface IBoardInitializer
    {
         UInt64 InitializeBoard(Player player, Piece pice);
    }
}