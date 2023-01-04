using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A6
{
    public class PartTimeEmployee : Employee
    {

        public float HourlyRate;

        public new void Display()
        {
            Console.WriteLine("PartTime Employee Details: ");
            Console.WriteLine("EmployeeID - {0}\nEmployee Name - {1}\nGender - {2}\nHourlyRate - {3} ", 
            this.EmployeeID, this.EmployeeName, this.Gender, this.HourlyRate);
            Console.WriteLine("");
        }
    }
}