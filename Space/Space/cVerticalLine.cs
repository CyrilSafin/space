using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class cVerticalLine:cFigure
    {
        public cVerticalLine(int x, int yUp, int yDown, char sym)
        {
            pointList = new List<cPoint>();

            for (int y = yUp; y <= yDown;y++)
            {
                cPoint p = new cPoint(x,y,sym);
                pointList.Add(p);
            }
        }
    }
}
