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
    public class DataManagerDB : IDataManager
    {
        public IList<Activity> Activities { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<Trainer> Trainers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<Client> Clients { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<Booking> Bookings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<Machine> Machines { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CancelActivity(Activity activity)
        {
            throw new NotImplementedException();
        }

        public bool CancelBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public bool DeleteClient(Client client)
        {
            throw new NotImplementedException();
        }

        public bool RegisterActivity(Activity activity)
        {
            throw new NotImplementedException();
        }

        public bool RegisterBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public bool RegisterClientInSystem(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
