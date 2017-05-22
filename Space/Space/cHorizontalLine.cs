using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class cHorizontalLine : cFigure
    {
        public cHorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pointList = new List<cPoint>();

            for (int x = xLeft; x <= xRight;x++)
            {
                cPoint p = new cPoint (x,y,sym);
                pointList.Add(p);
            }
        }
    }
}
