using System;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    
    class ConsoleUI
    {
        static GarageHandler garageHandler = new GarageHandler();

        static public void MainMenu()
        {
            var input = Utils.AskForIntInput("Please Select from the options from the Menu:" 
                + " \n1 - Create a new Garage"
                + " \n0 - Close the App");
            switch (input)
            {
                case 1:
                    OpenNewGarage();
                    break;
                case 0:
                    return;

                default:
                    Console.WriteLine("Please choose a valid option:");
                    MainMenu();
                    break;
            }
        }

        private static void OpenNewGarage()
        {
            while (true)
            {
                string garageName = Utils.AskForStringInput("Please write the name of Garage:"
                    + " (Enter 0 to go back to Main Menu)");
                if (garageName == "0") break;

                int garageCapacity = Utils.AskForIntInput("Please enter the Maximum Capacity of your Garage:"
                    + "(Enter 0 to go back to Main Menu)");
                if (garageCapacity == 0) break;

                var garage = garageHandler.CreateGarage(garageName, garageCapacity);

                Console.WriteLine($" \"{ garage.Name}'s\"Garage  with a Maximum Capacity of {garage.MaxCapacity} has been successfully Created.");
                GarageMenu(garage);
                break;
            }
        }

        private static void GarageMenu( Garage<Vehicle> garage)
        {
            Console.WriteLine("");
            var input = Utils.AskForIntInput("___________________________" +
                "Please Select from the Options below" +
                "\n1- Display List of all Parked Vehicles" +
                "\n2- Display List of specific type of Vehicals Parked" +
                "\n3- Park a Vehical" +
                "\n4- Unpark a Vehical" +
                "\n5- Search a Vehical with it's Specific Property" +
                "\n6- Search a Vehical with it's Registration Number" +
                "\n0- Go back to Man Menu");
            switch (input)
            {
                case 1: 
                    garageHandler.ListOfAllParkedVehicles(garage);
                    GarageMenu(garage);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 0:
                    MainMenu();
                    break;

                default:
                    break;
            }

        }
    }
}
