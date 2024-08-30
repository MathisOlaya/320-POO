using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Windows settings 
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;

            //Instantiate plane
            Plane plane = new Plane(0);

            while (true)
            {
                plane.MovePlane();

                //Speed
                Thread.Sleep(100);
            }
        }
    }
}
