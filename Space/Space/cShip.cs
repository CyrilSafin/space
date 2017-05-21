using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class cShip
    {
        List<cFigure> lineShip;
        public int coordinata=37;

        public cShip()
        {
            lineShip = new List<cFigure>();

            int width=0;
            do
            {
                cVerticalLine line = new cVerticalLine(coordinata, 20, 22, '*');
                lineShip.Add(line);
                coordinata++;
                width++;
            }
            while (width < 3);
        }
        public void Show()
        {
            foreach (var line in lineShip)
            { line.DrawFigure(); }
        }
      
    }
}
