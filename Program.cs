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

            double runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                //Prompt the user to enter minutes exercised 
                Console.Write("Enter how many minutes you exercised or type 'quit' to exit: ");
                string entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    keepGoing = false;
                }

                else
                {
                    try
                    {

                        double minutes = double.Parse(entry);

                        if (minutes <= 0)
                        {
                            Console.WriteLine(minutes + " is not an acceptable value, please try again.");
                            continue;
                        }

                        else if (minutes <= 10)
                        {
                            Console.WriteLine("Better than nothing!");
                        }
                        else if (minutes <= 30)
                        {
                            Console.WriteLine("Way to go hot stuff!");
                        }
                        else if (minutes <= 60)
                        {
                            Console.WriteLine("You must be a ninja warrior in training!");
                        }
                        else
                        {
                            Console.WriteLine("Okay now you're showing off!");
                        }

                        runningTotal = runningTotal + minutes;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("That is not a valid input");
                    }

                    Console.WriteLine("You've entered " + runningTotal + " minutes!");
                    //repeat until the user quits 

                }

            }


            Console.WriteLine("Goodbye!");

        }
    }
}
