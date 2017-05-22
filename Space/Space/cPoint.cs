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

        public void MovePoint(int offset, cDirection direction)
        {
            if (direction == cDirection.RIGHT)
            { x = x + offset; }
            else if (direction == cDirection.LEFT)
            { x = x - offset; }
            //if (direction == Direction.UP)
            //{ y = y - offset; }
            //else if (direction == Direction.DOWN)
            //{ y = y + offset; }
        }

        public void ClearPoint()
        {
            sym = ' ';
            DrawPoint();
        }

        public cPoint(cPoint p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

    }
}
