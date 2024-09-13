using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Helpers
{
    public static class GlobalHelpers
    {
        public static readonly Random Rand = new();
        public static int Alea(int min, int max)
        {
            return Rand.Next(min, max);
        }
    }
}
