using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        public static void ObjectPicker()
        {
            Console.WriteLine("What would you like to pick, orange or banana?");
            string input = Console.ReadLine();

            if (input == "orange")
            {
                Console.WriteLine("You have picked orange!");
                Thread.Sleep(1000);
            }
            else if (input == "banana")
            {
                Console.WriteLine("You have picked banana!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Error in picking an object, try again! Remember that command must be written in lowercase (Press ENTER to continue)");
                Console.ReadKey();
            }
        }

        public static void Run()
        {
            Console.WriteLine("Do you want play or exit the program? (play/exit)");
            string input;
            do
            {
                input = Console.ReadLine();
                if (input == "play")
                {
                    ObjectPicker();
                }
                else
                {
                    Console.WriteLine("Invalid command, try again!");
                }
            } while (input != "exit");

            Console.WriteLine("The End.");
        }

    }
}
