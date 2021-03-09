using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EGym.Logic;

namespace EGym.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic.EGym gym = new Logic.EGym();
            while (true)
            {
                Console.WriteLine("Press R to Register a New Activity:  ");
                Console.WriteLine("Press S to see the Gym schedule: ");
                Console.WriteLine("Press Q to Exit the system: ");

                var pressedKey = Console.ReadLine();

                switch (pressedKey)
                {
                    case "R":
                        break;
                    case "S":
                        var result = gym.ShowSchedule();
                        Console.WriteLine(result);
                        break;
                    case "Q":
                        Console.WriteLine("Thanks for using our App!");
                        return;
                    default:
                        break;
                }
            }

        }
    }
}
