using System;
using System.Collections.Generic;

namespace Classes
{
    public class Program
    {


        static void Main(string[] args)
        {


            Employee p1 = new Employee("Monica", "Kay", "CEO JI", new DateTime());
            Employee p2 = new Employee("Josh", "Barton", "Also CEO", new DateTime());
            Employee p3 = new Employee("Kanye", "West", "CEO of Flow", new DateTime());

            List<Employee> empz = new List<Employee>()
            {
                p1, p2, p3
            };

            // Create an instance of a company. Name it whatever you like.
            // new invokes the constructor
            Company apple = new Company("Apple Co.", new DateTime(), empz);

            // Create three employees exnae(object initializer)
            Employee n1 = new Employee("a", "b", "c", new DateTime());
            Employee n2 = new Employee("d", "e", "f", new DateTime());
            Employee n3 = new Employee("g", "h", "i", new DateTime());

            List<Employee> newEmpz = new List<Employee>
            {
                n1,n2,n3
            };

            // Assign the employees to the company
            foreach (Employee emp in newEmpz)
            {
                apple.CurrEmps.Add(emp);
            }
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            apple.ListEmployees(apple.CurrEmps);

            //create new gov  obj
            Gov usa = new Gov("The USA", true, apple);

            usa.HowWeSupportU();
        }
    }
}



/*Expand on the Company class code by
Adding an Employees property (Its type should be List<Employee>)

Setting the value of Employees in the constructor as a 
new List<Employee> (News Flash: Declaring a property gives it an 
initial vlaue of null). This will allow you to add newly created 
employees to the Employees list in the final step below.

Create an Employee.cs file and then define a class for Employee.
 An employee has the following properties.
First name (string)
Last name (string)
Title (string)
Start date (DateTime)

The Company class should also have a ListEmployees() method which writes 
a string to the console about each employee, such as "Jane Doe works 
for Acme, Inc. as Lion Tamer since 3/23/15."

In the Main method of your console application, create a new instance of 
Company, and three instances of Employee. Then assign the employees to the 
company.
*/