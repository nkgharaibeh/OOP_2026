using System;

namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// Demonstrates why enum can be better than bool.
    /// </summary>
    public static class EnumDemo
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=== Part 4: Enum Demo ===");
            Console.WriteLine();

            TimeSheet timeSheet = new TimeSheet();

            timeSheet.AddEntry("Ali", 4, PayRate.Normal);
            timeSheet.AddEntry("Mona", 4, PayRate.Weekend);
            timeSheet.AddEntry("Omar", 4, PayRate.Holiday);

            Console.WriteLine("Explanation: enum PayRate gives meaningful named choices.");
            Console.WriteLine("It is more expressive than bool isWeekend.");
        }
    }
}
