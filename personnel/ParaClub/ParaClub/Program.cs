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

            //Settings
            Console.CursorVisible = true;

            //Instantiate plane
            Plane plane = new Plane(0);

            //Instantiate player
            Para player1 = new Para();

            plane.Draw();
            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(false);
                    switch (cki.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            player1.Draw(plane._x);
                            break;
                    }
                }

                plane.Update();

                //Speed
                Thread.Sleep(100);
            }
        }
    }
}
