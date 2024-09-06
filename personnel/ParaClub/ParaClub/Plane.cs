using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Plane
    {
        public int _x;


        public Plane(int x) 
        {
            _x = x;
        }
        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        public void Draw()
        {
            //Dessiner la premiere fois l'avion
            Console.SetCursorPosition(_x, 0);
            foreach (string line in view)
            {
                Console.WriteLine(line);
            }
        }

        public void Update()
        {
            //Déplacer la zone
            Console.MoveBufferArea(_x, 0, view[0].Length, 6, _x + 1, 0);

            //Placer le curseur
            Console.SetCursorPosition(_x, 0);

            _x++;
        }
    }
}
