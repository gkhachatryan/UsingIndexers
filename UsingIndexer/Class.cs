using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingIndexer
{
    public class SolarSystem
    {

        public string[] planetsName = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };
        private int planetNumber { get; set; }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index > planetNumber)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return planetsName[index];
                }

            }
            set
            {
                planetsName[index] = value;
            }
        }

    }

    public class WeekDays
    {
        public string[] daysName = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private int dayNumber { get; set; }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index > dayNumber)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return daysName[index];
                }
            }
            set
            {
                daysName[index] = value;
            }
        }
    }
}
