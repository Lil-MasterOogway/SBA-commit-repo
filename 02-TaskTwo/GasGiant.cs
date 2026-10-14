using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    public class GasGiant : Planet
    {
        // Write task 2, step 4 here
        public GasGiant(string name, int yearLengthInEarthDays) : base(name, yearLengthInEarthDays)
        {
        }
        // Write task 2, step 5 here
        public override string Describe()
        {
            return "This is a gas giant planet.";
        }
    }
}
