using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaClub
{
    public class Para
    {
        string _name;

        int x;
        
        public Para(string name)
        {
            _name = name;
        }

        public void checkKeyPressed()
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.Spacebar:
                        JumpPara();
                        break;
                }
            }
        }

        private void JumpPara()
        {
            Console.SetCursorPosition(x, 10);
            Console.WriteLine("Here");
        }
    }
}
