using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace RandomSquares
{
    public class VirtualScreen
    {
        private VirtualScreenRow[] _rows;
        private int counter = 0;
        public VirtualScreen(int width, int height) {
            _rows = new VirtualScreenRow[height * width];
        }
        public void Add(Box box) {
            VirtualScreenRow v = new VirtualScreenRow(box.Width);
            v.AddBoxTopRow(box.X, box.Width);
            for (int i = 1; i < box.Height - 1; i++)
            {
                v.AddBoxMiddleRow(box.X, box.Width);
            }
            v.AddBoxBottomRow(box.X, box.Width);
            _rows[counter] = v;
            counter++;
        }
        public void Show() {
            for (int i = 0; i < counter; i++)
            {
                _rows[i].Show();
            }
        }
    }
}
