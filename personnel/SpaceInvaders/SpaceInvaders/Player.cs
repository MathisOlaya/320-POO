using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Player
    {
        Bullet bullet;
        private List<Bullet> Bullets = new List<Bullet>();

        private const char PLAYER_CHAR = 'O';

        private readonly int DEFAULT_POS_X = Console.WindowWidth / 2 - 1;
        private readonly int DEFAULT_POS_Y = Console.WindowHeight - 5;

        private int Player_Pos_X;

        public Player()
        {
            Initalize();

            Player_Pos_X = DEFAULT_POS_X;
        }
        private void Initalize()
        {
            //Draw player
            Console.SetCursorPosition(DEFAULT_POS_X, DEFAULT_POS_Y);
            Console.Write(PLAYER_CHAR);
        }
        public void Update()
        {
            CheckDeplacement();
            //bullets update 
            foreach(Bullet blt in Bullets)
            {
                blt.Update();
            }
        }
        public void CheckDeplacement()
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D:
                        Draw(1);
                        break;
                    case ConsoleKey.A:
                        Draw(-1);
                        break;
                    case ConsoleKey.Spacebar:
                        EmitShoot();
                        break;
                }
            }
        }
        public void EmitShoot()
        {
            bullet = new Bullet(Player_Pos_X, DEFAULT_POS_Y);
            Bullets.Add(bullet);
        }
        private void Draw(int direction)
        {
            Console.MoveBufferArea(
                Player_Pos_X,
                DEFAULT_POS_Y,
                PLAYER_CHAR.ToString().Length,
                1,
                Player_Pos_X > 5 && Player_Pos_X < Console.WindowWidth - 5
                    ? Player_Pos_X += direction
                    : (Player_Pos_X <= 5 && direction == 1)
                        ? Player_Pos_X += 1
                        : Player_Pos_X >= Console.WindowWidth - 5 && direction == -1
                            ? Player_Pos_X -= 1
                            : Player_Pos_X,
                DEFAULT_POS_Y);
        }
    }
}
