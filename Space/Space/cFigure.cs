using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class cFigure
    {
        protected List<cPoint> pointList;

        public void DrawFigure()
        {
            foreach (cPoint p in pointList)
            {
                p.DrawPoint();
            }
        }
    }
}
