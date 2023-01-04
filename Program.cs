using System;

namespace A6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee FTE1 = new FullTimeEmployee()
            {
                EmployeeID = 101,
                EmployeeName = "Joshua",
                Gender = "Male",
                Salary = 6000
            };

            FullTimeEmployee FTE2 = new FullTimeEmployee()
            {
                EmployeeID = 103,
                EmployeeName = "Daniel",
                Gender = "Male",
                Salary = 3000
            };

            PartTimeEmployee PTE1 = new PartTimeEmployee()
            {
                EmployeeID = 108,
                EmployeeName = "Precious",
                Gender = "Female",
                HourlyRate = 4
            };

            FTE1.Display();
            FTE2.Display();
            PTE1.Display();

        }

    }
}