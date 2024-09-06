using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParaClub
{
    public class Program
    {
        public static List<Para> parachutists = new List<Para>();
        static void Main(string[] args)
        {
            //Windows settings 
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;
            Console.CursorVisible = false;

            //Settings
            Console.CursorVisible = false;

            //instance plane
            Plane plane = new Plane();

            //draw plane 
            plane.Draw();

            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(false);

                    switch(cki.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        case ConsoleKey.Spacebar:
                            plane.DropParachutists();
                            break;
                    }
                }
                plane.Update();

                foreach(Para para in parachutists)
                {
                    para.Update();
                }


                Thread.Sleep(50);
            }

        

            
        }
    }
}
