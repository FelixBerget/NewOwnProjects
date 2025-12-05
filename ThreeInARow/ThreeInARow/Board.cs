using System;
using System.Collections.Generic;
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
        public void Mark(int index) {
            if (b[index].IsOwnedByPlayerTwo())
            {
                return;
            }
            b[index].PlayerTakes(true);
        }
        public void MarkRandom(bool player)
        {
            int randomNum = 0;
            Random r = new Random();
            while (b[randomNum].IsOwnedByPlayerOne() && b[randomNum].IsOwnedByPlayerTwo())
            {
                randomNum = r.Next(0, 8);
            }
            b[randomNum].PlayerTakes(player);
        }
    }
}
