using OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Models;
using OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Utilities;

namespace OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Services
{
    /// <summary>
    /// StudentReportService belongs to the Services namespace.
    ///
    /// It uses the Student class from the Models namespace.
    /// This demonstrates how namespaces organize classes in a larger program.
    ///
    /// Related slide ideas:
    /// - using statements allow us to use classes from other namespaces.
    /// - A program can contain many classes in different namespaces.
    /// </summary>
    public class StudentReportService
    {
        public void PrintReport(Student student)
        {
            Printer.PrintTitle("Student Report");
            Console.WriteLine(student.GetSummary());
        }
    }
}
