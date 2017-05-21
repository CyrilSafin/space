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
            Console.SetBufferSize(80, 25);

            cBorder border = new cBorder(80, 25);
            border.Show();

            cShip TheShip = new cShip();
            TheShip.Show();
            

            Console.ReadKey();
        }
    }
}
