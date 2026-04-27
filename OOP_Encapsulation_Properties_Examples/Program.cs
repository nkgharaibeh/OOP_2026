using System;

namespace OOP_Encapsulation_Properties_Examples
{
    /// <summary>
    /// This program contains several small examples related to:
    /// Encapsulation, private fields, properties, get/set, validation, computed properties,
    /// and static properties.
    ///
    /// These examples are designed to support the slides:
    /// "C# OOP - Encapsulation and Properties".
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("C# OOP - Encapsulation and Properties Demo");
            Console.WriteLine("==========================================");

            Example01_PublicFieldsProblem();
            Example02_EncapsulationWithStudent();
            Example03_EmployeeProperties();
            Example04_StaticProperty();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void Example01_PublicFieldsProblem()
        {
            Console.WriteLine();
            Console.WriteLine("Example 1: Problem with public fields");
            Console.WriteLine("-------------------------------------");

            // This class is intentionally designed badly.
            // It shows what happens when data is public and not protected.
            BadStudent badStudent = new BadStudent();

            badStudent.Name = "Ahmad";

            // This is logically wrong, but the class allows it because GPA is public.
            badStudent.GPA = 9.5;

            Console.WriteLine($"Bad Student: {badStudent.Name}, GPA = {badStudent.GPA}");
            Console.WriteLine("Problem: Public fields allow invalid data.");
        }

        private static void Example02_EncapsulationWithStudent()
        {
            Console.WriteLine();
            Console.WriteLine("Example 2: Encapsulation with properties and validation");
            Console.WriteLine("-------------------------------------------------------");

            Student student = new Student(1001, "Sara", 3.6);

            Console.WriteLine(student.GetSummary());

            // Valid value.
            student.GPA = 3.9;
            Console.WriteLine(student.GetSummary());

            // Invalid value.
            // The property setter protects the private field.
            student.GPA = 6.0;
            Console.WriteLine(student.GetSummary());
        }

        private static void Example03_EmployeeProperties()
        {
            Console.WriteLine();
            Console.WriteLine("Example 3: Employee properties");
            Console.WriteLine("------------------------------");

            Location irbid = new Location("Irbid Campus");
            Location amman = new Location("Amman Branch");

            Employee emp = new Employee("Michael Jones", "mjones", irbid, "0790000000");

            Console.WriteLine(emp.GetSummary());

            // PhoneNumber has get and set, so it can be changed from outside the class.
            emp.PhoneNumber = "0788888888";

            // Location has no public property; it is changed through a method.
            emp.Move(amman);

            Console.WriteLine(emp.GetSummary());

            // Email is a computed property.
            // It is not stored as a field.
            Console.WriteLine($"Email: {emp.Email}");
        }

        private static void Example04_StaticProperty()
        {
            Console.WriteLine();
            Console.WriteLine("Example 4: Static property");
            Console.WriteLine("--------------------------");

            Console.WriteLine($"Current Max Entries: {TimeSheet.MaxEntries}");

            TimeSheet.IncreaseMaxEntriesBy(10);

            Console.WriteLine($"Updated Max Entries: {TimeSheet.MaxEntries}");
        }
    }
}
