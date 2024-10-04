
namespace Drones
{
    public interface IDrone
    {
        int Charge { get; }
        bool LowBattery { get; }
        string Name { get; }
        int X { get; }
        int Y { get; }

        bool Evacuate(Rectangle zone);
        void FreeFlight();
        EvacuationState GetEvacuationState();
        void Render(BufferedGraphics drawingSpace);
        string ToString();
        void Update(int interval);
    }
}