using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class cBorder
    {
        List<cFigure> borderList;

        public cBorder(int screenWidth, int screenHeigh)
        {
            borderList = new List<cFigure>();

            cHorizontalLine upLine = new cHorizontalLine(0, screenWidth-2, 0, '=');
            cHorizontalLine downLine = new cHorizontalLine(0, screenWidth-2, screenHeigh-2, '=');
            cVerticalLine rightLine = new cVerticalLine(0, 0, screenHeigh-2, '|');
            cVerticalLine leftLine = new cVerticalLine(screenWidth-2, 0, screenHeigh-2, '|');

            borderList.Add(upLine);
            borderList.Add(downLine);
            borderList.Add(leftLine);
            borderList.Add(rightLine);
        }

        public void Show()
        {
            foreach (var border in borderList)
            { border.DrawFigure(); }
        }
    }
}
