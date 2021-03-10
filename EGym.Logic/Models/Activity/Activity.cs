using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGym.Logic.Models.Activity
{
    public class Activity
    {
        public DateTime StartTime { get; set; }
        public DateTime BookingDate { get; set; }
        public int Duration { get; set; }
        public int Id { get; set; }

        public Activity(DateTime startTime, DateTime bookningDate, int duration, int id)
        {
            this.StartTime = startTime;
            this.BookingDate = bookningDate;
            this.Duration = duration;
            this.Id = id;
        }

        public virtual string GetActivityType()
        {
            return "Base Activity";
        }
    }
}
