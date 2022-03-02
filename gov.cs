using System;
using System.Collections.Generic;

namespace Classes
{
    public class Gov
    {
        //properties
        public string Name { get; set; }
        public bool InvadeForeignCountryToSupportBusinessInterest { get; set; }

        public Company Co { get; set; }

        //constructor
        public Gov(string name, bool ifctsbi, Company co)
        {
            Name = name;
            InvadeForeignCountryToSupportBusinessInterest = ifctsbi;
            Co = co;
        }

        //method to display properties
        public void HowWeSupportU()
        {
            Console.WriteLine($"The {this.Name} supports {this.Co.Name}! \nThe allegations that we are invading places to support their operations is {this.InvadeForeignCountryToSupportBusinessInterest}");
        }
    }
}