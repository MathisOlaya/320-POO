using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Para
    {
        private int x;
        private string username;
        private int altitude = 6;

        public Para(string name) 
        {
            username = name;
        }
        public string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
        };
        public string[] withParachute =
        {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
        };

        public int X { get => x; set => x = value; }

        public void Draw(string[] parachuteAnimation)
        {
            for(int y = 0; y < withoutParachute.Length; y++)
            {
                Console.SetCursorPosition(x, y + altitude);
                Console.Write(parachuteAnimation[y]);

                if(y == 0)
                {
                    Console.SetCursorPosition(x, y + altitude);
                    Console.Write(username);
                }
            }
        }
       
        public void Update()
        {
            if(altitude < Config.SCREEN_HEIGHT - 6)
            {
                if (altitude < Config.SCREEN_HEIGHT / 2)
                {
                    Console.MoveBufferArea(x, altitude, withoutParachute[0].Length + 1, 6, x, altitude + 3);
                    altitude += 3;
                }
                else
                {
                    Console.MoveBufferArea(x, altitude, withoutParachute[0].Length + 1, 6, x, altitude + 1);
                    altitude += 1;
                    Draw(withParachute);
                }

            }
            else
            {
                Draw(withoutParachute);
            }
            
        }
    }
}
