using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo
{
    public abstract class Planet
    {
        // Write task 2, step 1 here
        protected string name;
        protected int yearLengthInEarthDays;
        public Planet(string name, int yearLengthInEarthDays)
        {
            this.name = name;
            this.yearLengthInEarthDays = yearLengthInEarthDays;
        }

        // Write task 2, step 2 here
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int YearLengthInEarthDays
        {
            get { return yearLengthInEarthDays; }
            set { yearLengthInEarthDays = value; }
        }

        // Write task 2, step 3 here
        public abstract string Describe();
    }
}
