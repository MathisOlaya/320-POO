using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Para
    {
        private string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
        };
        private string[] withParachute =
        {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
        };
        public void Draw(int x)
        {
            int y = 3;
            
            foreach (string line in withoutParachute)
            {
                Console.SetCursorPosition(x, y++);
                Console.WriteLine(line);
            }
        }

        public void Drop()
        {

        }
    }
}
