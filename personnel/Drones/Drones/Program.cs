using Drones.Helpers;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cr�ation de la flotte de drones
            List<Drone> fleet = new()
            {
                new("Joe", 100, 100),
            };
            List<Building> buildings = new()
            {
                new(300, 300, 140, 200, Color.Yellow),
            };

            // D�marrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}