using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne
{
    public class Planet
    {
        private string name;
        private int numberOfMoons;
        private bool hasRings;

        // Write task 1, step 1 here
        public Planet(string name, int numberOfMoons, bool hasRings)
        {
            this.name = name;
            this.numberOfMoons = numberOfMoons;
            this.hasRings = hasRings;
        }
        // Write task 1, step 2 here
        public string Name
        {
            get { return name; }
            set { name  = value; }
        }
        public bool HasRings
        {
            get { return hasRings; }
            set { hasRings = value; }
        }

        public int NumberOfMoons
        {
            get => numberOfMoons;
            set
            {
                // Write task 1, step 3 here
                if (numberOfMoons != value)
                {
                    throw ArgumentOutOfRangeException("Number of moons cannot be negative");
                }
                numberOfMoons = value;
            }
        }

        private Exception ArgumentOutOfRangeException(string v)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{name} {numberOfMoons} {hasRings}";
        }
    }
}
