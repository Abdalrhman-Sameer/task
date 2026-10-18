using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using task;

namespace main
{
    public class PartTimeEmployee : Employee, IWorkable
    {
        private int hoursWorked;
        private decimal hourlyRate;

        public override string EmployeeType
        {
            get { return "Part-Time"; }
        }

        public PartTimeEmployee(int id, string name,
            int hoursWorked, decimal hourlyRate)
            : base(id, name)
        {
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
        }

        public override decimal CalculateSalary()
        {
            SetSalary(hoursWorked * hourlyRate);
            return Salary;
        }

        public void Work()
        {
            Console.WriteLine(Name + " is working part-time.");
        }
    }
}
