using System;
using System.Threading;

namespace Snail
{
    public class Program
    {
        static private int speed = 160;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;

            //variables 
            int _x1 = 0;
            int _y1 = 5;
            int _x2 = 0;
            int _y2 = 10;

            //init snail
            Snail snail_1 = new Snail(_x1, _y1, "yoyo", ConsoleColor.Red);
            Snail snail_2 = new Snail(_x2, _y2, "matod", ConsoleColor.Green);

            //Create race
            Race race = new Race();
            //Draw race line
            race.DrawRaceLine(_x1, _y1, snail_1);

            while (snail_1.IsFinished() && snail_2.IsFinished())
            {
                race.Start(snail_1, snail_2);

                //speed
                Thread.Sleep(speed);

                //check if there's a winner
                race.checkFinish(snail_1, snail_2);
            }
            
        }
    }
}
