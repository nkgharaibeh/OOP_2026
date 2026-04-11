using System;

namespace OOBasicsDemo_v2
{
    /// <summary>
    /// Program class contains the Main method.
    /// This matches the slides that describe Main as the entry point
    /// of a C# console application.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating Location objects using the new keyword.
            // Object diagram idea:
            // [irbidOffice : Location]   [ammanOffice : Location]
            Location irbidOffice = new Location("Irbid Campus");
            Location ammanOffice = new Location("Amman Branch");

            // Creating Employee objects.
            // Class vs Object:
            // Employee = class
            // emp1, emp2, emp3 = objects (instances)
            Employee emp1 = new Employee("Susan Brown", "sbrown", irbidOffice, "0790000001");
            Employee emp2 = new Employee("Michael Jones", "mjones", irbidOffice, "0790000002");
            Employee emp3 = new Employee();

            // Creating supporting objects.
            TimeSheet timeSheet = new TimeSheet();
            Department softwareDepartment = new Department("Software Engineering");

            // Department has-a collection of Employee objects.
            softwareDepartment.AddEmployee(emp1);
            softwareDepartment.AddEmployee(emp2);
            softwareDepartment.AddEmployee(emp3);

            Console.WriteLine("=== Employee Information ===");
            Console.WriteLine(emp1.GetSummary());
            Console.WriteLine(emp2.GetSummary());
            Console.WriteLine(emp3.GetSummary());

            Console.WriteLine();
            Console.WriteLine("=== Email Example ===");

            // Request message:
            // Program asks Employee for information.
            Console.WriteLine(emp1.Email());

            Console.WriteLine();
            Console.WriteLine("=== Move Example ===");

            // Changing object state through a method call.
            emp2.Move(ammanOffice);
            Console.WriteLine(emp2.GetSummary());

            Console.WriteLine();
            Console.WriteLine("=== Overtime Example ===");

            // Sequence diagram idea:
            // Program -> emp2.RecordOvertime(timeSheet, 3)
            // emp2 -> timeSheet.AddEntry("Michael Jones", 3)
            emp2.RecordOvertime(timeSheet, 3);

            Console.WriteLine();
            Console.WriteLine("=== Department Example ===");
            softwareDepartment.PrintEmployees();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
