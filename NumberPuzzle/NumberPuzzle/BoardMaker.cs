using System;
using System.Collections.Generic;
using System.Text;

namespace NumberPuzzle
{
    internal class BoardMaker
    {

        public static string[] board = { " ", "1", "2", "3", "4", "5", "6", "7", "8" };
        
        public static string[] MovePieceRight()
        {
            if (board[8]==" ")
            {
                Console.WriteLine("YOU WON!");
                return board;
            }
            int index = board.IndexOf(" ");
            if (index % 3 == 2)
            {
                return board;
            }
            string temp = board[index+1];
            board[index+1] = board[index];
            board[index] = temp;
            return board;
        }

        public static string[] MovePieceLeft()
        {
            int index = board.IndexOf(" ");
            if (index % 3 == 0)
            {
                return board;
            }
            string temp = board[index - 1];
            board[index - 1] = board[index];
            board[index] = temp;
            return board;
        }
        public static string[] MovePieceDown()
        {
            int index = board.IndexOf(" ");
            if (index + 3 >= board.Length)
            {
                return board;
            }
            string temp = board[index + 3];
            board[index + 3] = board[index];
            board[index] = temp;
            return board;
        }
        public static string[] MovePieceUp()
        {
            int index = board.IndexOf(" ");
            if (index - 3 < 0)
            {
                return board;
            }
            string temp = board[index - 3];
            board[index - 3] = board[index];
            board[index] = temp;
            return board;
        }
    }
}
