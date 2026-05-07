using System;

namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// Demonstrates struct as a value type.
    /// </summary>
    public static class StructDemo
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=== Part 5: Struct Demo ===");
            Console.WriteLine();

            OvertimeEntry entry = new OvertimeEntry("Huda", 6, PayRate.Weekend);

            Console.WriteLine("Original entry:");
            Console.WriteLine(entry.GetSummary());

            ChangeStruct(entry);

            Console.WriteLine("After ChangeStruct:");
            Console.WriteLine(entry.GetSummary());

            Console.WriteLine("Explanation: OvertimeEntry is a struct.");
            Console.WriteLine("A copy of the struct was passed to the method.");
        }

        private static void ChangeStruct(OvertimeEntry entry)
        {
            entry = new OvertimeEntry("Changed Name", 99, PayRate.Holiday);

            Console.WriteLine("Inside ChangeStruct:");
            Console.WriteLine(entry.GetSummary());
        }
    }
}
