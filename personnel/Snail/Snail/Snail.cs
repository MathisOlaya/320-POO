using System;

namespace Snail
{
    public class Snail
    {
        //Constantes
        public const string SNAIL_MOVING = "_@_ö";

        //Variables
        public int intPV;
        private int _x;
        private int _y;
        private string snail_name;
        private ConsoleColor snail_color;

        public Snail(int x, int y, int PV, string name, ConsoleColor color)
        {
            _x = x;
            _y = y;
            snail_name = name;
            snail_color = color;
            intPV = PV;

            Draw();
        }

        private void Draw()
        {
            //Ecrire
            Console.ForegroundColor = snail_color;
            Console.SetCursorPosition(_x, _y);
            Console.Write(SNAIL_MOVING);
            Console.ResetColor();
        }
        public void MoveSnail()
        {
            //Place snail
            Console.MoveBufferArea(_x, _y, SNAIL_MOVING.Length, 1, _x + 1, _y);
            
            _x++;
            intPV--;
        }
        public bool IsFinished() => intPV > 0;
        public void killSnail(Snail winnerSnail)
        {
            Console.SetCursorPosition(20, 20);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Winner : " + winnerSnail.snail_name);
            Console.ReadLine();
        }
    }
}
