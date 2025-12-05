using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeInARow
{
    internal class GameConsole
    {

        public void Show(Board b)
        {
            int SideCounter = 1;
            Square[] squares  = b.GetSquares();
            string BoardString = "    a b c \n   ┌─────┐";
            for (int i = 0; i < squares.Length; i++)
            {
                if (i % 3 == 0)
                {
                    BoardString +=   "\n" + SideCounter +  "  │";
                    BoardString += squares[i].IsOwnedByPlayerOne() ? "X" : " ";
                    BoardString += squares[i].IsOwnedByPlayerTwo() ? "O" : " ";
                    SideCounter++;
                }
                else if (i % 3 == 1)
                {
                    BoardString += squares[i].IsOwnedByPlayerOne() ? "X" : " ";
                    BoardString += squares[i].IsOwnedByPlayerTwo() ? "O" : " ";
                    BoardString += " │";
                }
                else
                {
                    BoardString += squares[i].IsOwnedByPlayerOne() ? "X" : " ";
                    BoardString += squares[i].IsOwnedByPlayerTwo() ? "O" : " ";
                }
            }
            BoardString += "\n   └─────┘";
            Console.WriteLine(BoardString);
        }
    }
}
