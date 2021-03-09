using EGym.Logic.Models.Activity;
using EGym.Logic.Models.People;
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


    }
}
