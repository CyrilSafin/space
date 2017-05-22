using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class cShip:cFigure
    {
        cDirection direction;

        List<cHorizontalLine> allShipLine;

        public cShip(int _coordinataX, int _coordinataY, int _heigh, cDirection _direction)
        {
            int crdX = _coordinataX;
            int crdY = _coordinataY;
            int heigh = _heigh;
            direction = _direction;
            
            allShipLine = new List<cHorizontalLine>();

            List<cPoint> lineShip = new List<cPoint>();

            do
            {
                for (int i = 0; i < 3; i++)
                {
                    cPoint p = new cPoint(crdX, crdY, '*');
                    lineShip.Add(p);
                    crdX++;
                }
                cFigure line = new cFigure();
            }
            while (heigh < 2);

                //cHorizontalLine line = new cHorizontalLine(crdX, crdX+2, crdY, '*');
                //lineShip.Add(line);
                //crdY++;
                //heigh--;
            }
    

        internal void Move()
        {
            foreach (var line in allShipLine)
            {
                if (direction ==cDirection.LEFT)
                {
                    
                }

                else if (direction == cDirection.RIGHT)
                { }
            }
        }


        public void Show()
        {
            foreach (var line in allShipLine)
            { line.DrawFigure(); }
        }

        public void KeyControl(ConsoleKey Key)
        {
            if (Key == ConsoleKey.LeftArrow)
                direction = cDirection.LEFT;
            else if (Key == ConsoleKey.RightArrow)
                direction = cDirection.RIGHT;
        }
      
    }
}
