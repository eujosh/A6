using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A6
{
    public class FullTimeEmployee : Employee
    {
        public int Salary;

        public new void Display()
        {
            Console.WriteLine("FullTime Employee Details: ");
            Console.WriteLine("EmployeeID - {0}\nEmployee Name - {1}\nGender - {2}\nEmployee Salary - {3} ", 
            this.EmployeeID, this.EmployeeName, this.Gender, this.Salary);
            Console.WriteLine("");
        }
    }
}