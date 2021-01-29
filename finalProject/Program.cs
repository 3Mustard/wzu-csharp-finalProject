using System;
using System.Linq;
using EmployeeClass;
using EmpoyeeFactory;

namespace finalProject
{
    // MAIN METHOD in CLASS PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = ContractorPayrollDemo();
            ContractorPayrollDemo2(employees);
        }
        static Employee[] ContractorPayrollDemo()
        {
            // Create 10 employees display the data and return them.
            Employee[] employees = EmployeeMaker.CreateEmployees(10);
            DisplayData(employees);
            return employees;

        }

        static void ContractorPayrollDemo2(Employee[] employees)
        {
            // Sort employees and display the data
            var sortedEmployees = employees.OrderBy(x => x.TotalIncome).ThenBy(y => y.Tax);
            DisplayData(sortedEmployees.ToArray());
        }

        public static void DisplayData(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Displaying data for employee {employee.ID} | Hours worked: {employee.HoursWorked} | Rate: {employee.RatePerHour} | State: {employee.State}");
            }
        }
    }
}
