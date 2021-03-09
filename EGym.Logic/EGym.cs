using EGym.Logic.Infrastructure;
using EGym.Logic.Models.Activity;
using EGym.Logic.Models.People;
using EGym.Logic.Models.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGym.Logic
{
    public class EGym
    {
        public IEnumerable<Activity> Activities { get; set; }
        public IEnumerable<Trainer> Trainers { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }

        public IDataManager DataManager { get; set; }

        



        public EGym()
        {
            
            DataManager = new DataManagerSimulator();

        }

        public bool CheckTrainerAvailability(int trainerId, DateTime startDate, DateTime endDate)
        {
            var result = Bookings.FirstOrDefault(b => (b.TrainerId == trainerId) && Utility.CheckDate(b.StartTime, b.EndTime, startDate, endDate));
            if (result != null)
            {
                return false;
            }
            return true;
        }

       


    }
}
