using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            cShip TheShip = new cShip(37,20, 3,cDirection.LEFT);
            TheShip.Show();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    //TheShip.Move();
                    Thread.Sleep(300);
                    
                    ConsoleKeyInfo key = Console.ReadKey();
                    TheShip.KeyControl(key.Key);
                }
            }




            Console.ReadKey();
        }
    }
}
