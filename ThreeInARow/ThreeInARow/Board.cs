using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ThreeInARow
{
    internal class Board
    {
        private Square[] b = new Square[9];
        public Board() {
            for (int i = 0; i < 9; i++)
            {
                b[i] = new Square();
            }
        }
        public Square[] GetSquares()
        {
            return b;
        }

        public void ResetBoard()
        {
            for(int i = 0; i < b.Length; i++)
            {
                b[i].ResetPiece();
            }
        }
        public void Mark(int index) {
            if (b[index].IsOwnedByPlayerTwo() || b[index].IsOwnedByPlayerOne())
            {
                Console.WriteLine("Already taken, write another");
                int newIndex = Convert.ToInt32(Console.ReadLine());
                Mark(newIndex);
                return;

            }
            b[index].PlayerTakes(true);
        }
        public void MarkRandom(bool player)
        {
            Random r = new Random();
            int randomNum = r.Next(0, 8);
            while (b[randomNum].IsOwnedByPlayerOne() || b[randomNum].IsOwnedByPlayerTwo())
            {
                randomNum = r.Next(0, 8);
            }
            b[randomNum].PlayerTakes(player);
        }

        public bool PlayerOneHasWon()
        {
            for (int i = 0; i < b.Length-1; i++)
            {
                if (i + 2 > 8)
                {

                }
                else if (b[i].IsOwnedByPlayerOne() && b[i+1].IsOwnedByPlayerOne() && (i + 1) % 3 != 0 && b[i + 2].IsOwnedByPlayerOne() && (i + 2) % 3 != 0)
                {
                    return true;
                }

                if (i + 6 > 8)
                {

                }
                else if (b[i].IsOwnedByPlayerOne() && b[i + 3].IsOwnedByPlayerOne() && b[i + 6].IsOwnedByPlayerOne())
                {
                    return true;
                }

                if (i + 8 > 8)
                {

                }
                else if (b[i].IsOwnedByPlayerOne() && b[i+4].IsOwnedByPlayerOne() && (i+4)%3!=0 && b[i + 8].IsOwnedByPlayerOne() && (i + 8) % 3 != 0)
                {
                    return true;
                }

            }
            return false;
        }
        public bool PlayerTwoHasWon()
        {
            for (int i = 0; i < b.Length-1; i++)
            {
                if (i + 2 > 8)
                {
                    
                }
                else if (b[i].IsOwnedByPlayerTwo() && b[i + 1].IsOwnedByPlayerTwo() && (i + 1) % 3 != 0 && b[i + 2].IsOwnedByPlayerTwo() && (i + 2) % 3 != 0)
                {
                    return true;
                }
                if (i + 6 > 8)
                {
                    
                }
                else if (b[i].IsOwnedByPlayerTwo() && b[i + 3].IsOwnedByPlayerTwo() && b[i + 6].IsOwnedByPlayerTwo())
                {
                    return true;
                }
                if(i+8 > 8)
                {

                }
                else if (b[i].IsOwnedByPlayerTwo() && b[i + 4].IsOwnedByPlayerTwo() && (i + 4) % 3 != 0 && b[i + 8].IsOwnedByPlayerTwo() && (i + 8) % 3 != 0)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
