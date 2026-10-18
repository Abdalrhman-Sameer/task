using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using task;

namespace main
{
    public class FullTimeEmployee : Employee, IWorkable
    {
        private decimal monthlySalary;

        public override string EmployeeType
        {
            get { return "Full-Time"; }
        }

        public FullTimeEmployee(int id, string name, decimal monthlySalary)
            : base(id, name)
        {
            this.monthlySalary = monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            SetSalary(monthlySalary);
            return Salary;
        }

        public void Work()
        {
            Console.WriteLine(Name + " is working full-time.");
        }
    }
}
