using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        public static readonly int DEFAULT_CHARGE = 1000;

        public int Charge { get; private set; }                     // La charge actuelle de la batterie
        public string Name { get; private set; }                           // Un nom
        public int X { get; private set; }                                // Position en X depuis la gauche de l'espace aérien
        public int Y { get; private set; }                                 // Position en Y depuis le haut de l'espace aérien
        public bool LowBattery { get; private set; }
        private EvacuationState EvacuationState { get; set; }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public Drone(string name, int x, int y) : base()
        {
            Charge = DEFAULT_CHARGE;
            Name = name;
            X = x;
            Y = y;
            EvacuationState = EvacuationState.Free;
        }

        public Drone()
        {
        }

        public void Update(int interval)
        {
            X += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            Y += GlobalHelpers.Alea(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            Charge--;                                  // Il a dépensé de l'énergie
            

            //Si la charge est plus petite que 20%.
            if(Charge < DEFAULT_CHARGE / 5 && !LowBattery)
                LowBattery = true;
        }

        public bool Evacuate(Rectangle zone)
        {
            //If don't have charge left.
            if(Charge <= 0) return false;

            //Check if is in zone
            bool isInZone = (X >= zone.X && X <= zone.X + zone.Width
                            && Y >= zone.Y && zone.Y <= zone.Y + zone.Height);

            if (isInZone)
            {
                //Change evacuation test
                EvacuationState = EvacuationState.Evacuating;

                X += (X >= zone.X + zone.Width / 2) ? 1 : -1;
                Y += (Y >= zone.Y + zone.Height / 2) ? 1 : -1;

                //Check if he's outside 
                if(X < zone.X || X > zone.X + zone.Width ||
                    Y < zone.Y || Y > zone.Y + zone.Height)
                {
                    EvacuationState = EvacuationState.Evacuated;
                    return true;
                }
                return false;
            }
            
            EvacuationState = EvacuationState.Evacuated;
            return true;
            
        }

        public void FreeFlight() => EvacuationState = EvacuationState.Free;


        public EvacuationState GetEvacuationState()
        {
            return EvacuationState;
        }
    }
}
