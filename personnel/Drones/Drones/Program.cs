using Drones.Helpers;
using System.Linq.Expressions;

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
                new("Joe", 75, 75),
          
            };
            List<Building> buildings = new()
            {
                new Factory(GlobalHelpers.Alea(0, 400), GlobalHelpers.Alea(0, 400), GlobalHelpers.Alea(0, 200), Color.Black, 100),
                new Factory(GlobalHelpers.Alea(0, 400), GlobalHelpers.Alea(0, 400), GlobalHelpers.Alea(0, 200), Color.Black, 100),
                new Store(GlobalHelpers.Alea(0, 300), GlobalHelpers.Alea(0, 300), GlobalHelpers.Alea(0, 300), Color.Red, new List<String>{"Lundi 8-16h", "Mardi 10h-12h"})
            };


            // Démarrage
            try
            {
                Application.Run(new AirSpace(fleet, buildings));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception : {e.Message}" );
            }
            
        }
    }
}