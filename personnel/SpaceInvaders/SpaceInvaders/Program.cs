using System;
using System.Threading;

namespace SpaceInvaders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Curseur
            Console.CursorVisible = false;

            //Créer le joueur
            Player player = new Player();

            //boucle du jeu
            while (true)
            {
                player.Update();

                Thread.Sleep(100);
            }
        }
    }
}
