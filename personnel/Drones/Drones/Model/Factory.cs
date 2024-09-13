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
        public Factory(int x, int y, int size, Color color, float powerConsumption) : base(x, y, size, size, color)
        {
            PowerConsumption = powerConsumption;
            Print();
        }
    }
}
