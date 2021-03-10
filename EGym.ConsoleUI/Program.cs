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
                Console.WriteLine("Press R to Register a New Client:  ");
                Console.WriteLine("Press S to see the Gym schedule: ");
                Console.WriteLine("Press L to get all clients: ");
                Console.WriteLine("Press Q to Exit the system: ");

                var pressedKey = Console.ReadLine();

                switch (pressedKey)
                {
                    case "R":
                        Console.WriteLine("Introduce Name: ");
                        string name = Console.ReadLine();
                        Random r = new Random();
                        int id = r.Next(10000);
                        bool wasPossible = gym.RegisterClient(id,name);
                        if (wasPossible)
                        {
                            Console.WriteLine("Client create successfully");
                        }
                        else
                        {
                            Console.WriteLine("The was an error in the system");
                        }
                        break;
                    case "S":
                        var result = gym.ShowSchedule();
                        Console.WriteLine(result);
                        break;
                    case "L":
                        var clients = gym.ListAllClients();
                        foreach (var item in clients)
                        {
                            Console.WriteLine("ClientId: {0} , Client Name: {1}", item.Id, item.Name);
                        }
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
