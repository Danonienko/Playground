using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public static void ObjectPicker()
        {
            Console.WriteLine("What would you like to pick, orange or banana?");
            string input = Console.ReadLine();

            if (input == "orange")
            {
                Console.WriteLine("You have picked orange!");
                Thread.Sleep(1000);
                TryAgain();
            }
            else if (input == "banana")
            {
                Console.WriteLine("You have picked banana!");
                Thread.Sleep(1000);
                TryAgain();
            }
            else
            {
                Console.WriteLine("Error in picking an object, try again! Remember that command must be written in lowercase (Press ENTER to continue)");
                Console.ReadKey();
                ObjectPicker();
            }
        }
        static void TryAgain()
        {
            Console.WriteLine("Do you want to try again or exit the program? (again/exit)");
            string input;

            do
            {
                input = Console.ReadLine();
                if (input != "again" && input != "exit")
                {
                    Console.WriteLine("Invalid command, try again!");
                }
                else
                {
                    if (input == "again")
                    {
                        ObjectPicker();
                    }
                    else if (input == "exit")
                    {
                        Console.WriteLine("Exiting...");
                    }
                }
            } while (input != "again" && input != "exit");
        }

    }
}
