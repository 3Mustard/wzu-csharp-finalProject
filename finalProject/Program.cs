using System;
using System.Linq;

namespace finalProject
{
    // MAIN METHOD in CLASS PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            ContractorPayrollDemo();
        }

        static void ContractorPayrollDemo()
        {
            // Create 10 employees
            Employee[] employees = EmployeeMaker.CreateEmployees(10);

            // Sort the employees by amount of paycheck then state tax
            Console.WriteLine("Displaying the sorted data for employees");
            ContractorPayrollDemo2(employees);
        }

        static void ContractorPayrollDemo2(Employee[] employees)
        {
            var sortedEmployees = employees.OrderBy(x => x.Total).ThenBy(y => y.Tax);

            foreach (Employee employee in sortedEmployees)
            {
                Console.WriteLine($"Displaying data for employee {employee.ID} | Hours worked: {employee.HoursWorked} | Rate: {employee.RatePerHour} | State: {employee.State}");
            }
        }
    }

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

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Displaying data for employee {employee.ID} | Hours worked: {employee.HoursWorked} | Rate: {employee.RatePerHour} | State: {employee.State}");
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

    // EMPLOYEE CLASS
    public class Employee
    {
        // Data Field Declaration
        public string id;
        public double hoursWorked, ratePerHour;
        public string state;

        // Property accessors: get; set;
        public string ID
        {
            set { id = value; }
            get { return id; }
        }
        public double HoursWorked
        {
            set { hoursWorked = value; }
            get { return hoursWorked; }
        }
        public double RatePerHour
        {
            set { ratePerHour = value; }
            get { return ratePerHour; }
        }
        public string State
        {
            set { state = value; }
            get { return state; }
        }
        // Read Only Properties: get;
        public double Tax { get; }
        public double Total { get; }

        // Constructor
        public Employee(string id, double hoursWorked, double ratePerHour, string state)
        {
            ID = id;
            HoursWorked = hoursWorked;
            RatePerHour = ratePerHour;
            State = state;

            // Got confused about state taxes so here is a random number.
            var rand = new Random();
            int num = rand.Next(6);
            Tax = num * .01 ;

            Total = (hoursWorked * ratePerHour) * Tax;
        }
    }
}
