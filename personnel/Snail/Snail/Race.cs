using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    public class Race
    {
        public void Start()
        {
            Random rand = new Random();

            List<Snail> lst = Program.all_snails;

            foreach(Snail snail in lst)
            {
                if(rand.Next(1, 10) != 1)
                {
                    snail.MoveSnail();
                }
            }
        }
        public void checkFinish()
        {
            List<Snail> lst = Program.all_snails;

            foreach(Snail snail in lst)
            {
                if (!(snail.IsFinished())) { snail.killSnail(snail); }
            }
        }
        public void DrawRaceLine()
        {
            for(int y = 0; y< 5; y++)
            {
                for (int i = 0; i < 19; i++)
                {
                    if (y % 2 == 0) i++;

                    bool isBlack;
                    Console.SetCursorPosition(Program.START_POS + Program.SNAIL_PV + Snail.SNAIL_MOVING.Length + y, 2 + i);


                    //1 block sur 2
                    if (y % 2 == 0)
                        isBlack = i % 2 == 0;
                    else
                        isBlack = i % 2 != 0;

                    Console.BackgroundColor = isBlack ? ConsoleColor.Black : ConsoleColor.White;
                    Console.Write(' ');
                    Console.ResetColor();
                }
            }  
        }
    }
}
