using System;
using System.Collections.Generic;
using System.Text;

namespace main
{
    public abstract class Employee
    {
        private decimal salary;

        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Salary
        {
            get { return salary; }
        }

        protected void SetSalary(decimal value)
        {
            salary = value;
        }

        public abstract string EmployeeType { get; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateSalary();

        public string DisplayInfo()
        {
            return "ID: " + Id + ", Name: " + Name + ", Employee Type: " + EmployeeType + ", Salary: " + CalculateSalary() + " JOD";
        }
    }
}

