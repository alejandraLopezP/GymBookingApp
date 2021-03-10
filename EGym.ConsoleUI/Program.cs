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
                Console.WriteLine("Press A to create an activity: ");
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
                            Console.WriteLine("Client create successfully!");
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
                    case "A":
                        PrintMenu();
                        string option = Console.ReadLine();
                        BuildAction(option, gym);
                        break;
                    case "Q":
                        Console.WriteLine("Thanks for using our App!");
                        return;
                    default:
                        break;
                }
            }

        }

        private static void BuildAction(string option, Logic.EGym gym)
        {
            switch (option)
            {
                case "1":
                    Console.WriteLine("Introduce a date (yyyy-mm-dd): ");
                    string[] dateStr = Console.ReadLine().Split('-');
                    int d = int.Parse(dateStr[2]);
                    int m = int.Parse(dateStr[1]);
                    int y = int.Parse(dateStr[0]);
                    DateTime dateBuilt = new DateTime(y, m, d);
                    Console.WriteLine("Please introduce your Customer Id: ");
                    int customerId = int.Parse(Console.ReadLine());
                    bool customerExist = gym.CheckUserId(customerId);
                    if (!customerExist)
                    {
                        Console.WriteLine("The Id introduced doesn´t exist");
                        return;
                    }
                    else
                    {
                        Random r = new Random();
                        int id = r.Next(10000);
                        gym.RegisterActivity(id, dateBuilt);
                        var clientIds = new List<int>() { customerId };
                        gym.BookActivity(id, -1, dateBuilt, dateBuilt.AddDays(1),clientIds);
                    }
                    break;
                default:
                    break;
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Press 1 to Individual Training:");
            Console.WriteLine("Press 2 to Individual Training with PT:");
            Console.WriteLine("Press 3 to Consultation with PT:");
            Console.WriteLine("Press 4 to Group Training with PT:");
        }
    }
}
