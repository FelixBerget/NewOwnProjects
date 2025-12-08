using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeInARow
{
    internal class Square
    {
        private bool IsEmpty;
        private bool OwnedByPlayerOne;
        private bool OwnedByPlayerTwo;
        public Square() { 

            IsEmpty = true;
            OwnedByPlayerOne = false;
            OwnedByPlayerTwo = false;
        }

        public void PlayerTakes(bool player)
        {
            if (player)
            {
                OwnedByPlayerOne = true;
            }
            else if (!player) 
            {
                OwnedByPlayerTwo= true;
            }

        }
        public bool IsOwnedByPlayerOne()
        {
            return OwnedByPlayerOne; 
        }
        public bool IsOwnedByPlayerTwo()
        {
            return OwnedByPlayerTwo;
        }
        public void ResetPiece()
        {
            OwnedByPlayerOne= false;
            OwnedByPlayerTwo = false;
        }
    }
}
