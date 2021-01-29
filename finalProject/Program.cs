using System;
using System.Collections.Generic;

namespace finalProject
{
    // MAIN METHOD in CLASS PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public static class EmployeeMaker
    {
        public static List<Employee> CreateEmployees(int amount)
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Please enter data for employee {i+1}/{amount}");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Enter employee ID: ");
                int ID
            }
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
        // Read Only Properties: get;
        public double Tax { get; }
    }
}


//Instantiate each element of array: 
//for (int i = 0; i < employees.Length; i++)
//{
//    employees[i] = new Employee();
//}

//Get employee info for each employee:
//for (int i = 0; i < employees.Length; i++)
//{
//    Console.WriteLine($"Employee {i + 1}: " +
//        $"please enter employee ID: ");
//    employees[i].ID = Int32.Parse(Console.ReadLine());
//    Console.WriteLine($"Employee {i + 1}:" +
//        $" please enter hourly rate: ");
//    employees[i].hourlyRate = Decimal.Parse(Console.ReadLine());
//    Console.WriteLine(
//        $"Employee {i + 1}: please enter number of hours worked: ");
//    employees[i].numOfHoursWorked = float.Parse(Console.ReadLine());
//    Console.WriteLine($"Employee {i + 1}: please enter state: ");
//    employees[i].state = Console.ReadLine();
//}