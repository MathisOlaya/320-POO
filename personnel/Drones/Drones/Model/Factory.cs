using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Factory : Building
    {
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
    }
}
