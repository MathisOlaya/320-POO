using System;
using System.Threading;

namespace SpaceInvaders
{
    public class Bullet
    {
        private readonly int BULLET_POS_X;
        private int Bullet_Pos_Y;

        private readonly char BULLET_CHAR = '|';

        public Bullet(int pos_x, int pos_y)
        {
            //Bullet pos
            BULLET_POS_X = pos_x;
            Bullet_Pos_Y = pos_y - 1;

            //Init
            Initialize();
        }
        public void Initialize()
        {
            //Place cursor 
            Console.SetCursorPosition(BULLET_POS_X, Bullet_Pos_Y);
            Console.Write(BULLET_CHAR);
        }
        public void Update()
        {
            MoveBullet();
        }
        public void MoveBullet()
        {
            Console.MoveBufferArea(BULLET_POS_X, Bullet_Pos_Y, BULLET_CHAR.ToString().Length, 1, BULLET_POS_X, Bullet_Pos_Y > 1 ? Bullet_Pos_Y -= 1 : Bullet_Pos_Y);
            CheckBulletLimit();
        }
        private void CheckBulletLimit()
        {
            if(Bullet_Pos_Y == 1)
            {
                Console.SetCursorPosition(BULLET_POS_X, Bullet_Pos_Y);
                Console.Write(' ');
            }
        }
    }
}
