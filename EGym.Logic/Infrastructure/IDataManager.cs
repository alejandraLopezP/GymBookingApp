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
        bool RegisterClientInSystem(Client client);
        bool DeleteClient(Client client);

        bool RegisterActivity(Booking booking);
        bool CancelActivity(Booking booking);


        
    }
}
