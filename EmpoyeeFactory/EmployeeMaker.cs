using System;
using EmployeeClass;

namespace EmpoyeeFactory
{
    // EMPLOYEE CLASS MAKER
    public static class EmployeeMaker
    {
        // Create x amount of Employees
        public static Employee[] CreateEmployees(int amount)
        {
            Employee[] employees = new Employee[amount];
            for (int i = 0; i < amount; i++)
            {
                // get user data
                Console.WriteLine($"Please enter data for employee {i + 1}/{amount}");
                Console.WriteLine("Enter Employee ID: ");
                string id = Console.ReadLine();
                Console.WriteLine($"Enter the hourly rate for Employee {id}: ");
                double rate = GetCheckDouble();
                Console.WriteLine($"Hours worked?: ");
                double totalHours = GetCheckHours();
                Console.WriteLine("State work was performed in?: ");
                string state = Console.ReadLine();

                // create an employee and add to list of employees
                Employee employee = new Employee(id, totalHours, rate, state);
                employees[i] = employee;
                // Confirmation msg
                Console.WriteLine($"Success!");
                Console.WriteLine($"Created employee {employee.ID} | Hours worked: {employee.HoursWorked} | Rate: {employee.RatePerHour} | State: {employee.State}");
                Console.WriteLine("-----------------------------------------------");
            }

            return employees;
        }

        // DATA VALIDATION FOR AN EMPLOYEE
        // A double
        private static double GetCheckDouble()
        {
            double validDouble;
            double.TryParse(Console.ReadLine(), out validDouble);

            return validDouble;
        }

        // Hours are reasonable 
        private static double GetCheckHours()
        {
            double hours = GetCheckDouble();
            while (hours > 168 || hours < 0)
            {
                Console.WriteLine("That is an invalid amount of hours to have worked, try again.");
                hours = GetCheckDouble();
            }

            return hours;
        }
    }
}
