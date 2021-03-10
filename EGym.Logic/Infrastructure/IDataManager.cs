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
    public interface IDataManager
    {
        IList<Activity> Activities { get; set; }
        IList<Trainer> Trainers { get; set; }
        IList<Client> Clients { get; set; }
        IList<Booking> Bookings { get; set; }
        IList<Machine> Machines { get; set; }

        bool RegisterClientInSystem(Client client);
        bool DeleteClient(Client client);

        bool RegisterBooking(Booking booking);
        bool CancelBooking(Booking booking);
        bool RegisterActivity(Activity activity);
        bool CancelActivity(Activity activity);



    }
}
