namespace Drones
{
    public partial class Factory : Building
    {
        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.FillRectangle(_brush, new Rectangle(X, Y, Width, Height));
        }
        protected override void Print()
        {
            base.Print();

            Console.WriteLine("Consomation " + PowerConsumption);
        }
    }
}
