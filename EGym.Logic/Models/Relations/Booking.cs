using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGym.Logic.Models.Relations
{
    public class Booking
    {
        public int TrainerId { get; internal set; }
        public int ActivityId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        
    }
}
