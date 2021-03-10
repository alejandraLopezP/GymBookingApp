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
      

        public IDataManager DataManager { get; set; }
        

        

        public EGym()
        {
            
            DataManager = new DataManagerSimulator();

        }

        public object ShowSchedule()
        {
            return "This is the schedule for today: ";
        }

        public bool CheckMachineAvailability(int machineId, DateTime startDate)
        {
            var result = DataManager.Machines.FirstOrDefault(m => m.Id == machineId);

            if (result == null)
            {
                return false;
            }

            if (Utility.IsMachineReparationDate(result.ReparationDate, startDate))
            {
                return false;
            }
            return true;
        }
        public bool CheckTrainerAvailability(int trainerId, DateTime startDate, DateTime endDate)
        {
            var result = DataManager.Bookings.FirstOrDefault(b => b.TrainerId == trainerId);
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

        public void BookActivity(int activityId, int trainerId, DateTime startDate, DateTime endDate, List<int> clientIds)
        {
            var booking = new Booking() { ActivityId = activityId, TrainerId = trainerId, StartTime = startDate, EndTime = endDate, ClientIds = clientIds };
            DataManager.RegisterBooking(booking);
            
        }

        public bool RegisterClient(int id, string name)
        {
            var client = new Client() { Id = id, Name = name };
            DataManager.RegisterClientInSystem(client);
            return true;
        }
        
        public IEnumerable<Client> ListAllClients()
        {
            return DataManager.Clients;
        }

       


    }
}
