using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone
    {
        private const int DEFAULT_CHARGE = 1000;

        public int Charge { get; private set; }                     // La charge actuelle de la batterie
        public string Name { get; private set; }                           // Un nom
        public int X { get; private set; }                                // Position en X depuis la gauche de l'espace aérien
        public int Y { get; private set; }                                 // Position en Y depuis le haut de l'espace aérien


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public Drone(string name, int x, int y)
        {
            Charge = DEFAULT_CHARGE;
            Name = name;
            X = x;
            Y = y;
        }
        public void Update(int interval)
        {
            X += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            Y += GlobalHelpers.Alea(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            Charge--;                                  // Il a dépensé de l'énergie
        }

    }
}
