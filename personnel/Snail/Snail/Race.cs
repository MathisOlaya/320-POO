using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    public class Race
    {
        public void Start(Snail snail_1, Snail snail_2)
        {
            Random rand = new Random();
            bool snail1Avance = true;
            bool snail2Avance = true;

            //add random stop
            if(rand.Next(1, 10) == 1)
                snail1Avance = false;
            
            if (rand.Next(1, 10) == 1)
                snail2Avance = false;
            
            if (snail1Avance != false)
            {
                snail_1.MoveSnail();
                snail1Avance = true ;
            }
            if (snail2Avance != false)
            {
                snail_2.MoveSnail();
                snail2Avance = true;
            }
            
            
        }
        public void checkFinish(Snail snail_1, Snail snail_2)
        {
            if(!(snail_1.IsFinished())) { snail_1.killSnail(snail_1); }
            if (!(snail_2.IsFinished())) { snail_2.killSnail(snail_2); }
        }
        public void DrawRaceLine(int _x, int _y, Snail snail)
        {
            for(int y = 0; y< 4; y++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (y % 2 == 0) i++;

                    bool isBlack;
                    Console.SetCursorPosition(_x + snail.intPV + snail.SNAIL_MOVING.Length + y, _y - 2 + i);


                    //1 block sur 2
                    isBlack = i % 2 == 0;

                    Console.BackgroundColor = isBlack ? ConsoleColor.Black : ConsoleColor.White;
                    Console.Write(' ');
                    Console.ResetColor();
                }
            }  
        }
    }
}
