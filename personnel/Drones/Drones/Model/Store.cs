using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Drones
{
    public partial class Store : Building
    {
        public List<String> OpeningHours { get; private set; }
        public Store(int x, int y, int radius, Color color, List<String> openingHours) : base(x, y , radius, radius, color)
        {
            OpeningHours = openingHours;
            Print();
        }
    }
}
