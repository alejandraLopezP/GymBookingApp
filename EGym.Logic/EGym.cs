using EGym.Logic.Infrastructure;
using EGym.Logic.Models.Activity;
using EGym.Logic.Models.Machine;
using EGym.Logic.Models.People;
using EGym.Logic.Models.Relations;
using EGym.Logic.Utilities;
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
        public IEnumerable<Machine> Machines { get; set; }

        public IDataManager DataManager { get; set; }
        

        



        public EGym()
        {
            
            DataManager = new DataManagerSimulator();

        }

        public bool CheckTrainerAvailability(int trainerId, DateTime startDate, DateTime endDate)
        {
            var result = Bookings.FirstOrDefault(b => b.TrainerId == trainerId);
            //sino hay ningún Trainer en la lista de Bookings con ese Id es porque ese Trainer esta libre
            if (result == null)
            {
                return true;
            }
            //si hay un Trainer reservado en la lista de Bookings pero la fecha solicitada no se solapa con la fecha de este booking,
            //el Trainer esta disponible.
            if (!Utility.CheckDate(result.StartTime, result.EndTime, startDate, endDate))
            {
                return true;
            }
            return false;
        }

        public void BookActivity(int activityId, int trainerId, DateTime startDate, DateTime endDate)
        {
            var booking = new Booking() { ActivityId = activityId, TrainerId = trainerId, StartTime = startDate, EndTime = endDate};
            DataManager.RegisterActivity(booking);
        }

       


    }
}
