using EGym.Logic.Models.Activity;
using EGym.Logic.Models.Machine;
using EGym.Logic.Models.People;
using EGym.Logic.Models.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGym.Logic.Infrastructure
{
    public class DataManagerSimulator : IDataManager
    {
        public IList<Activity> Activities { get; set; }
        public IList<Trainer> Trainers { get; set; }
        public IList<Client> Clients { get; set; }
        public IList<Booking> Bookings { get; set; }
        public IList<Machine> Machines { get; set; }

        public DataManagerSimulator()
        {
            Activities = new List<Activity>();
            Trainers = new List<Trainer>();
            Clients = new List<Client>();
            Bookings = new List<Booking>();
            Machines = new List<Machine>();
        }
        public bool CancelActivity(Activity activity)
        {
            var result = Activities.FirstOrDefault(a => a.Id == activity.Id);
            return Activities.Remove(result);
        }

        public bool CancelBooking(Booking booking)
        {
            var result = Bookings.FirstOrDefault(b => b.Id == booking.Id);
            return Bookings.Remove(result);
        }

        public bool DeleteClient(Client client)
        {
            var result = Clients.FirstOrDefault(c => c.Id == client.Id);
            return Clients.Remove(result);
        }

        public bool RegisterActivity(Activity activity)
        {
            Activities.Add(activity);
            return true;
        }

        public bool RegisterBooking(Booking booking)
        {
            Bookings.Add(booking);
            return true;
        }

        public bool RegisterClientInSystem(Client client)
        {
            Clients.Add(client);
            return true;
        }
    }
}
