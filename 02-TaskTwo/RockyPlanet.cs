using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    public class RockyPlanet : Planet
    {
        // Write task 2, step 6 here
        public RockyPlanet(string name, int yearLengthInEarthDays) : base(name, yearLengthInEarthDays)
        {
        }
        // Write task 2, step 7 here
        public override string Describe()
        {
            return "This is a rocky planet.";
        }
    }
}
