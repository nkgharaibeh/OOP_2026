using System;

namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// Version 3 builds on OOBasicsDemo_v2.
    ///
    /// v2 focused on:
    /// - Classes
    /// - Objects
    /// - Constructors
    /// - Methods
    /// - has-a / uses-a relationships
    ///
    /// v3 adds:
    /// - Value types vs reference types
    /// - Stack and heap conceptual understanding
    /// - Parameter passing
    /// - enum
    /// - struct
    /// - boxing and unboxing
    /// - build / CLR / JIT notes
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=================================================");
            Console.WriteLine("OOBasicsDemo_v3 - Data Types, Objects, References");
            Console.WriteLine("=================================================");

            OriginalOOBasicsDemo();

            MemoryDemo.RunValueTypeDemo();
            MemoryDemo.RunReferenceTypeDemo();

            EnumDemo.Run();
            StructDemo.Run();
            BoxingDemo.Run();

            BuildRuntimeDemo.PrintBuildProcessSummary();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// This method keeps the original spirit of OOBasicsDemo_v2.
        /// It creates Employee, Location, TimeSheet, and Department objects.
        /// </summary>
        private static void OriginalOOBasicsDemo()
        {
            Console.WriteLine();
            Console.WriteLine("=== Part 1: Original OOP Basics Demo ===");
            Console.WriteLine();

            Location irbidOffice = new Location("Irbid Campus");
            Location ammanOffice = new Location("Amman Branch");

            Employee emp1 = new Employee("Susan Brown", "sbrown", irbidOffice, "0790000001");
            Employee emp2 = new Employee("Michael Jones", "mjones", irbidOffice, "0790000002");
            Employee emp3 = new Employee();

            TimeSheet timeSheet = new TimeSheet();
            Department softwareDepartment = new Department("Software Engineering");

            softwareDepartment.AddEmployee(emp1);
            softwareDepartment.AddEmployee(emp2);
            softwareDepartment.AddEmployee(emp3);

            Console.WriteLine("Employee Information:");
            Console.WriteLine(emp1.GetSummary());
            Console.WriteLine(emp2.GetSummary());
            Console.WriteLine(emp3.GetSummary());

            Console.WriteLine();
            Console.WriteLine("Email Example:");
            Console.WriteLine(emp1.Email());

            Console.WriteLine();
            Console.WriteLine("Move Example:");
            emp2.Move(ammanOffice);
            Console.WriteLine(emp2.GetSummary());

            Console.WriteLine();
            Console.WriteLine("Overtime Example using enum PayRate:");
            emp2.RecordOvertime(timeSheet, 3, PayRate.Weekend);

            Console.WriteLine();
            Console.WriteLine("Department Example:");
            softwareDepartment.PrintEmployees();
        }
    }
}
