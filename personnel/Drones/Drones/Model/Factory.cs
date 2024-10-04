using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
        //Timer
        private int BoxProductionTimer = 0;
        private const int BOX_PRODUCTION_DELAY = 5000;

        public float PowerConsumption {get; private set;}

        public int FactoryID { get; private set;}
        private static List<int> FactoriesID = new List<int>() { 0};

        public Factory(int x, int y, int size, Color color, float powerConsumption) : base(x, y, size, size, color)
        {
            FactoryID = FactoriesID[FactoriesID.Count - 1] + 1;
            FactoriesID.Add(FactoryID);

            PowerConsumption = powerConsumption;
            Print();
        }
        public void Update(int interval)
        {
            //Incrémenter le timer 
            BoxProductionTimer += interval;
            
            //Créer un carton toute les 5 secondes 
            if(BoxProductionTimer >= BOX_PRODUCTION_DELAY + GlobalHelpers.Alea(0, 2000))
            {
                //reset timer
                BoxProductionTimer = 0;

                //Create a new box 
                Console.WriteLine("New box buddy");
            }

        }
    }
}
