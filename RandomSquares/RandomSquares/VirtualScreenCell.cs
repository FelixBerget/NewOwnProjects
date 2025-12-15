using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSquares
{
    class VirtualScreenCell
    {
        public bool Up { get; private set; }
        public bool Down { get; private set; }
        public bool Left { get; private set; }
        public bool Right { get; private set; }
        public VirtualScreenCell()
        {
            Up = false;
            Down = false;
            Left = false;
            Right = false;
        }

        public char GetCharacter()
        {
            if(Up && Down && Left && Right)
            {
                return '┼';
            }
            else if(Up && Down && Left)
            {
                return '┤';
            }
            else if (Up && Down && Right)
            {
                return '├';
            }
            else if(Down && Right && Left)
            {
                return '┬';
            }
            else if(Up && Right && Left)
            {
                return '┴';
            }
            else if(Left && Down)
            {
                return '┐';
            }
            else if (Right && Down)
            {
                return '┌';
            }
            else if(Left && Up)
            {
                return '┘';
            }
            else if(Right && Up)
            {
                return '└';
            }
            else if (Up && Down)
            {
                return '│';
            }
            else if (Left && Right)
            {
                return '─';
            }
            else if (Up)
            {
                return '╹';
            }
            else if (Down)
            {
                return '╻';
            }
            else if (Right)
            {
                return '╺';
            }
            else if (Left)
            {
                return '╸';
            }
            return ' ';
        }
        public void AddHorizontal() { 
            this.Right = true;
            this.Left = true;

        }
        public void AddVertical() {
            this.Up = true;
            this.Down = true;
        }
        public void AddLowerLeftCorner() {
            this.Right = true;
            this.Up = true;
        }
        public void AddUpperLeftCorner() {
            this.Right = true;
            this.Down= true;
        }
        public void AddUpperRightCorner() {
            this.Left = true;
            this.Down = true;
        }
        public void AddLowerRightCorner() {
            this.Left= true;
            this.Up = true;
        }
    }
}
