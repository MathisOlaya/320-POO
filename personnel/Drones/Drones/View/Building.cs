using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public abstract partial class Building
    {
        protected SolidBrush _brush;

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(_brush, new Rectangle(X , Y, Width, Height));
        }
        protected virtual void Print()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Width : " + Width);
            Console.WriteLine("X et Y " + X + " " + Y);
            Console.WriteLine("Color : " + Color);
        }
    }
}
