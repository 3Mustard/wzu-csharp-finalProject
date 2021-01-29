using System;
using System.Collections.Generic;

namespace finalProject
{
    // MAIN METHOD in CLASS PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeMaker.CreateEmployees(2);
        }
    }

    public static class EmployeeMaker
    {
        // Create x amount of Employees
        public static List<Employee> CreateEmployees(int amount)
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < amount; i++)
            {
                // get user data
                Console.WriteLine($"Please enter data for employee {i+1}/{amount}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Enter Employee ID: ");
                string id = Console.ReadLine();
                Console.WriteLine($"Enter the hourly rate for Employee {id}: ");
                double rate = double.Parse(Console.ReadLine());
                Console.WriteLine($"Hours worked?: ");
                double totalHours = double.Parse(Console.ReadLine());
                Console.WriteLine("State work was performed in?: ");
                string state = Console.ReadLine();

                // create an employee and add to list of employees
                Employee employee = new Employee(id, totalHours, rate, state);
                employees.Add(employee);
                // Confirmation msg
                Console.WriteLine($"Success!");
                Console.WriteLine($"Created employee {employee.ID} | Hours worked: {employee.HoursWorked} | Rate: {employee.RatePerHour} | State: {employee.State}");
                Console.WriteLine("-----------------------------------------------");
            }

            return employees;
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

        // Constructor
        public Employee(string id, double hoursWorked, double ratePerHour, string state)
        {
            ID = id;
            HoursWorked = hoursWorked;
            RatePerHour = ratePerHour;
            State = state;
        }
    }
}
