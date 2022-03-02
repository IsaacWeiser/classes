using System;
using System.Collections.Generic;


namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> CurrEmps { get; set; }

        public void ListEmployees(List<Employee> emps)
        {
            foreach (Employee person in emps)
            {
                Console.WriteLine($"{person.Fname} {person.Lname}");
            }
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */
        //constructor
        public Company(string name, DateTime createdOn, List<Employee> currEmps)
        {
            Name = name;
            CreatedOn = createdOn;
            CurrEmps = currEmps;
        }
    }
}