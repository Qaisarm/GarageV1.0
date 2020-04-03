using System;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    public static class Utils
    {
        /// <summary>
        /// 
        ///  Static class cant make instances of. 
        ///  Exactly as the Console class for example
        ///  
        ///  <summary>
        public static string AskForStringInput(string prompt)
        {
            bool correct = true;
            string input; //Scope

            do // Repeat
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();


                //If answer is not null or empty string

                if (!string.IsNullOrEmpty(input))
                {
                    //Set bool correct to false to exit loop

                    correct = false;
                }
            } while (correct); //until we have get a correct value

            return input;  //return value

        }

        public static int AskForIntInput(string prompt)
        {
            bool success;
            int answer; //Scope

            do // Repeat
            {
                string input = AskForStringInput(prompt);

                //Try to parse string to int returns bool

                //If true exit loop

                success = int.TryParse(input, out answer);
                if (!success)
                {
                    //Write errormessage

                    Console.WriteLine("This is not a number\n Please enter a number again.");

                }
            } while (success);

            //Returns parsed string

            return answer;
        }
    }
}
