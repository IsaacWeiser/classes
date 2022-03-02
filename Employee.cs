using System;

namespace Classes
{
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }


        public Employee(string empFname, string empLname, string empTitle, DateTime empStartDate)
        {
            Fname = empFname;
            Lname = empLname;
            Title = empTitle;
            StartDate = empStartDate;
        }
    }

}