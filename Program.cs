using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHouseTraining_FitnessFrog
{
    class Program
    {
        static void Main(string[] args)
        {

            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                //Prompt the user to enter minutes exercised 
                Console.Write("Enter how many minutes you exercised or type 'Quit' to exit: ");
                string entry = Console.ReadLine();

                if (entry == "Quit")
                {
                    keepGoing = false;
                }

                else
                {
                    int minutes = int.Parse(entry);
                    runningTotal = runningTotal + minutes;
                    //Add minutes exercised to total
                    //display total minutes exercised to the screen
                    Console.WriteLine("You've entered " + runningTotal + " minutes!");
                    //repeat until the user quits 

                }

            }


            Console.WriteLine("Goodbye!");

        }
    }
}
