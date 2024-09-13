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

            // Création de la flotte de drones
            List<Drone> fleet = new()
            {
                new("Joe", 100, 100),
            };
            List<Building> buildings = new()
            {
                new Factory(GlobalHelpers.Alea(0, 800), GlobalHelpers.Alea(0, 800), GlobalHelpers.Alea(0, 500), Color.Black, 100),
                new Store(GlobalHelpers.Alea(0, 800), GlobalHelpers.Alea(0, 800), GlobalHelpers.Alea(0, 300), Color.Red, new List<String>{"Lundi 8-16h", "Mardi 10h-12h"})
            };
            

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}