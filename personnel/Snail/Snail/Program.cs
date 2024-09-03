using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Snail
{
    public class Program
    {
        static private int speed = 160;

        public static List<Snail> all_snails { get; set; }

        public const int START_POS = 0;
        public const int SNAIL_PV = 50;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;

            //variables 


            //init snail
            Snail snail_1 = new Snail(START_POS, 5, SNAIL_PV, "yoyo", ConsoleColor.Red);
            Snail snail_2 = new Snail(START_POS, 10, SNAIL_PV, "matod", ConsoleColor.Green);
            Snail snail_3 = new Snail(START_POS, 15, SNAIL_PV,"chonchon", ConsoleColor.Cyan);
            Snail snail_4 = new Snail(START_POS, 20, SNAIL_PV,"zebi", ConsoleColor.Magenta);

            //instantiate list
            all_snails = new List<Snail>();

            //add to list
            all_snails.Add(snail_1);
            all_snails.Add(snail_2);
            all_snails.Add(snail_3);
            all_snails.Add(snail_4);


            //Create race
            Race race = new Race();
            //Draw race line
            race.DrawRaceLine();

            while (true)
            {
                race.Start();

                //speed
                Thread.Sleep(speed);

                //check if there's a winner
                race.checkFinish();
            }
            
        }
    }
}
