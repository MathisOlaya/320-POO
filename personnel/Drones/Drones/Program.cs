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
                new("Joe", 100, 10),
                new("Joe", 150, 160),
                new("Joe", 160, 110),
                new("Joe", 170, 134),
                new("Joe", 120, 173),
                new("Joe", 150, 124),
                new("Joe", 180, 186),
                new("Joe", 190, 124),
                new("Joe", 120, 165),
                new("Joe", 110, 134),
                new("Joe", 155, 199),
                new("Joe", 134, 123),
                new("Joe", 124, 189),
            };
            List<Building> buildings = new()
            {
                new Factory(GlobalHelpers.Alea(0, 800), GlobalHelpers.Alea(0, 800), GlobalHelpers.Alea(0, 500), Color.Black, 100),
                new Store(GlobalHelpers.Alea(0, 800), GlobalHelpers.Alea(0, 800), GlobalHelpers.Alea(0, 300), Color.Red, new List<String>{"Lundi 8-16h", "Mardi 10h-12h"})
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