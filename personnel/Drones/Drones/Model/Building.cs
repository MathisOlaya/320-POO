using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        public int X {  get; private set; }
        public int Y { get; private set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

       public Building(int x, int y, int width, int height, Color color) 
       {
            X = x;
            Y = y;
            Width = width; 
            Height = height;
            _buildBrush = new(color);
       }

    }
}
