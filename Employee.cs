using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A6
{
    public class Employee
    {
        public int EmployeeID {get; set;}
        public string? EmployeeName {get; set;}
        public string? Gender {get; set;}

        public void Display()
        {
            Console.WriteLine(this.EmployeeID + " " + this.EmployeeName);
        }

    }
}