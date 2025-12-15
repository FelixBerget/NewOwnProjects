using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSquares
{
    public class VirtualScreenRow
    {
        private VirtualScreenCell[] _cells;
        int width;
        VirtualScreenCell[] topCells;
        VirtualScreenCell[] middleCells;
        VirtualScreenCell[] bottomCells;
        public VirtualScreenRow(int screenWidth) {
            width = screenWidth;
        }

        public void AddBoxTopRow(int boxX, int boxWidth) {
            topCells = new VirtualScreenCell[boxWidth+boxX];
            for(int i = 0; i < boxX; i++)
            {
                VirtualScreenCell part = new VirtualScreenCell();
                topCells[i] = part;
            }
            for (int i = boxX; i < boxX+boxWidth; i++)
            {
                if (i == boxX)
                {
                    VirtualScreenCell first = new VirtualScreenCell();
                    first.AddUpperLeftCorner();
                    topCells[i] = first;
                }
                else if (i == boxX + boxWidth - 1)
                {
                    VirtualScreenCell last = new VirtualScreenCell();
                    last.AddUpperRightCorner();
                    topCells[i] = last;
                }
                else
                {
                    VirtualScreenCell middle = new VirtualScreenCell();
                    middle.AddHorizontal();
                    topCells[i] = middle;
                }
            }
        }
        public void AddBoxMiddleRow(int boxX, int boxWidth) {
            middleCells = new VirtualScreenCell[boxWidth+boxX];
            for (int i = 0; i < boxX; i++)
            {
                VirtualScreenCell part = new VirtualScreenCell();
                middleCells[i] = part;
            }
            for (int i = boxX; i < boxWidth+boxX; i++)
            {
                if (i == boxX)
                {
                    VirtualScreenCell first = new VirtualScreenCell();
                    first.AddVertical();
                    middleCells[i] = first;
                }
                else if (i == boxX + boxWidth - 1)
                {
                    VirtualScreenCell last = new VirtualScreenCell();
                    last.AddVertical();
                    middleCells[i] = last;
                }
                else
                {
                    VirtualScreenCell part = new VirtualScreenCell();
                    middleCells[i] = part;
                }
            }
        }
        public void AddBoxBottomRow(int boxX, int boxWidth) {

            bottomCells = new VirtualScreenCell[boxWidth + boxX];
            for (int i = 0; i < boxX; i++)
            {
                VirtualScreenCell part = new VirtualScreenCell();
                bottomCells[i] = part;
            }
            for (int i = boxX; i < boxWidth+boxX; i++)
            {
                if (i == boxX)
                {
                    VirtualScreenCell first = new VirtualScreenCell();
                    first.AddLowerLeftCorner();
                    bottomCells[i] = first;
                }
                else if (i == boxX + boxWidth - 1)
                {
                    VirtualScreenCell last = new VirtualScreenCell();
                    last.AddLowerRightCorner();
                    bottomCells[i] = last;
                }
                else
                {
                    VirtualScreenCell middle = new VirtualScreenCell();
                    middle.AddHorizontal();
                    bottomCells[i] = middle;
                }
            }
        }
        public void Show() {
            ShowTop();
            ShowMiddle();
            ShowBottom();
        }

        public void ShowTop()
        {
            if (topCells == null) return;
            Console.WriteLine();
            for (int i = 0; i < topCells.Length; i++)
            {
                Console.Write(topCells[i].GetCharacter());
            }
        }
        public void ShowMiddle()
        {
            if (middleCells == null) return;
            Console.WriteLine();
            for (int i = 0; i < middleCells.Length; i++)
            {
                Console.Write(middleCells[i].GetCharacter());
            }
        }
        public void ShowBottom()
        {
            if(bottomCells == null) return;
            Console.WriteLine();
            for (int i = 0; i < bottomCells.Length; i++)
            {
                Console.Write(bottomCells[i].GetCharacter());
            }
        }
    }
}
