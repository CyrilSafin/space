using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Space
{
    class cPoint
    {
        int x;
        int y;
        char sym;

        public cPoint (int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void DrawPoint()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
