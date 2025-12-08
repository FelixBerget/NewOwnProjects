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
                    BoardString += squares[i].IsOwnedByPlayerOne() ? "X " : squares[i].IsOwnedByPlayerTwo() ? "O " : "  ";
                    SideCounter++;
                }
                else if (i % 3 == 2)
                {
                    BoardString += squares[i].IsOwnedByPlayerOne() ? "X" : squares[i].IsOwnedByPlayerTwo() ? "O" : " ";
                    BoardString += "│";
                }
                else
                {
                    BoardString += squares[i].IsOwnedByPlayerOne() ? "X " : squares[i].IsOwnedByPlayerTwo() ? "O " : "  ";
                }
            }
            BoardString += "\n   └─────┘";
            if (b.PlayerOneHasWon())
            {
                BoardString += "\n Victory for player 1";
            }
            if (b.PlayerTwoHasWon())
            {
                BoardString += "\n Victory for player 2";
            }
            Console.WriteLine(BoardString);
        }
    }
}
