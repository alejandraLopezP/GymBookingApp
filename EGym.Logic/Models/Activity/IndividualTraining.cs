using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGym.Logic.Models.Activity
{
    public class IndividualTraining : Activity
    {
        public IndividualTraining(DateTime startTime, DateTime bookningDate, int duration) : base(startTime, bookningDate, duration)
        {

        }

        public override string GetActivityType()
        {
            return "IndividualActivity";
        }
    }
}
