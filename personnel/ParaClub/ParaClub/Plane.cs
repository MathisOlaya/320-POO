using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Plane
    {
        private int _x = 0;
        private int paraNumber = 0;

        public static string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public int X { get => _x; set => _x = value; }

        public void Draw()
        {
            foreach(string line in view)
            {
                Console.WriteLine(line);
            }
        }
        public void Update()
        {
            if(_x + view[0].Length < Config.SCREEN_WIDTH)
            {
                Console.MoveBufferArea(_x, 0, view[0].Length, 6, _x + 1, 0);
                _x += 1;
            }
            
            
        }

        public void DropParachutists()
        {
            Para player = new Para("Blud" + paraNumber.ToString());
            paraNumber += 1;
            player.X = _x;
            player.Draw(player.withoutParachute);
            Program.parachutists.Add(player);
        }
    }
}
