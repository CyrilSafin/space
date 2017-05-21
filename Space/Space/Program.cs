using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);

            List<cPoint> HorizontalLine = new List<cPoint>();
            HorizontalLine.Add(p);

            for (int i = 0; i < 80;i++ )
            { 
                cPoint p1 = new cPoint(i, 0, '+');
                p1.DrawPoint();
            }
            

            

            Console.ReadKey();
        }
    }
}
