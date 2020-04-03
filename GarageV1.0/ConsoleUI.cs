using System;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    
    class ConsoleUI
    {
        static GarageHandler garage = new GarageHandler();
        static public void MainMenu()
        {
            var input = Utils.AskForIntInput("Please Select from the options from the Menue:" 
                + "\n1 - Create as new Garage" + "\n0 Close the App");
        }
    }
}
