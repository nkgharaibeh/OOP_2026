using System;
using OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Models;
using OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Services;
using OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Utilities;

namespace OOP_Namespaces_AccessModifiers_ThisKeyword_Examples
{
    /// <summary>
    /// Main program.
    ///
    /// This file demonstrates how classes from different namespaces
    /// can be used together in one program through using statements.
    ///
    /// Related slide ideas:
    /// - Many classes in one program
    /// - Namespaces organize classes
    /// - Access modifiers control visibility
    /// - this keyword refers to the current object
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("C# OOP - Namespaces, Access Modifiers, and this Demo");
            Console.WriteLine("====================================================");

            Example01_Namespaces();
            Example02_AccessModifiers();
            Example03_ThisKeyword();
            Example04_ServiceClass();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void Example01_Namespaces()
        {
            Console.WriteLine();
            Console.WriteLine("Example 1: Namespaces");
            Console.WriteLine("---------------------");

            // Student class belongs to the Models namespace.
            Student student = new Student(1001, "Sara", 3.7);

            // Printer class belongs to the Utilities namespace.
            Printer.PrintTitle("Student Created from Models Namespace");

            Console.WriteLine(student.GetSummary());
        }

        private static void Example02_AccessModifiers()
        {
            Console.WriteLine();
            Console.WriteLine("Example 2: Access Modifiers");
            Console.WriteLine("---------------------------");

            Student student = new Student(1002, "Ahmad", 3.2);

            // Public member: accessible from Program.
            Console.WriteLine(student.GetSummary());

            // The following line would cause a compilation error because name is private:
            // student.name = "New Name";

            Console.WriteLine("Private fields cannot be accessed directly from Program.");
            Console.WriteLine("We access data safely through public methods/properties.");
        }

        private static void Example03_ThisKeyword()
        {
            Console.WriteLine();
            Console.WriteLine("Example 3: this keyword");
            Console.WriteLine("-----------------------");

            // The constructor parameters have the same names as the fields.
            // Inside the constructor, this.id means the field of the current object,
            // while id means the parameter.
            Student student = new Student(1003, "Mona", 3.9);

            Console.WriteLine(student.GetSummary());
        }

        private static void Example04_ServiceClass()
        {
            Console.WriteLine();
            Console.WriteLine("Example 4: Service class");
            Console.WriteLine("------------------------");

            Student student = new Student(1004, "Omar", 2.8);

            StudentReportService reportService = new StudentReportService();

            reportService.PrintReport(student);
        }
    }
}
