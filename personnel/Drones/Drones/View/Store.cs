using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Store : Building
    {
        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillEllipse(_brush, new Rectangle(X, Y, Width, Height));
        }
        protected override void Print()
        {
            base.Print();

            foreach(string line in OpeningHours)
            {
                Console.WriteLine(line);
            }
        }
    }
}
