using main;
using System;

class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee emp1 = new FullTimeEmployee(1, "Ahmad", 1200);


        PartTimeEmployee emp2 = new PartTimeEmployee(2, "Omar", 50, 8);

        Console.WriteLine($"Employee Type: {emp1.EmployeeType}");

        Console.WriteLine("--------------------");

        Console.WriteLine($"Employee Type: {emp2.EmployeeType}");


        Console.WriteLine("--------------------");

        emp1.Work();
        emp2.Work();
    }
}
