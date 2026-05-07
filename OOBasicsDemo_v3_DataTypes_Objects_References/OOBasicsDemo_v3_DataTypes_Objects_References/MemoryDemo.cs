using System;

namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// Demonstrates value types, reference types, and parameter passing.
    /// </summary>
    public static class MemoryDemo
    {
        public static void RunValueTypeDemo()
        {
            Console.WriteLine();
            Console.WriteLine("=== Part 2: Value Type Parameter Passing ===");
            Console.WriteLine();

            int hours = 5;

            Console.WriteLine($"Before ChangeHours: hours = {hours}");

            ChangeHours(hours);

            Console.WriteLine($"After ChangeHours: hours = {hours}");
            Console.WriteLine("Explanation: int is a value type. A copy of the value was passed.");
        }

        private static void ChangeHours(int hours)
        {
            hours = 10;
            Console.WriteLine($"Inside ChangeHours: hours = {hours}");
        }

        public static void RunReferenceTypeDemo()
        {
            Console.WriteLine();
            Console.WriteLine("=== Part 3: Reference Type Parameter Passing ===");
            Console.WriteLine();

            Location irbid = new Location("Irbid Campus");
            Employee employee = new Employee("Sara Ahmad", "sara", irbid, "0791111111");

            Console.WriteLine("Before ChangeEmployeeLocation:");
            Console.WriteLine(employee.GetSummary());

            ChangeEmployeeLocation(employee);

            Console.WriteLine("After ChangeEmployeeLocation:");
            Console.WriteLine(employee.GetSummary());

            Console.WriteLine("Explanation: Employee is a reference type.");
            Console.WriteLine("A copy of the reference was passed, but both references point to the same object.");
        }

        private static void ChangeEmployeeLocation(Employee employee)
        {
            Location amman = new Location("Amman Branch");
            employee.Move(amman);
        }
    }
}
