using TaxDictionary;

namespace EmployeeClass
{
    // EMPLOYEE CLASS
    public class Employee
    {
        // Data Field Declaration
        public string id;
        public double hoursWorked, ratePerHour;
        private readonly string state;
        private readonly double totalIncome;

        // Property accessors:
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
        // READ ONLY
        public string State
        {
            get { return state; }
        }
        public double TotalIncome
        {
            get { return totalIncome; }
        }

        // Constructor
        public Employee(string id, double hoursWorked, double ratePerHour, string state)
        {
            this.id = id;
            this.hoursWorked = hoursWorked;
            this.ratePerHour = ratePerHour;
            this.state = state;
        }

        public double GrossIncome()
        {
            return hoursWorked * ratePerHour;
        }

        public double IncomeTax()
        {
            return TaxBracket.TaxBrackets()[this.State];
        }

        public double NetIncome()
        {
            return GrossIncome() - IncomeTax();
        }
    }
}
