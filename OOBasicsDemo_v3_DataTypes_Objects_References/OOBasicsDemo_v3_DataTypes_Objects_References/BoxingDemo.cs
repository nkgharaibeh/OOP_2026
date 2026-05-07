using System;

namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// Demonstrates boxing and unboxing.
    /// </summary>
    public static class BoxingDemo
    {
        public static void Run()
        {
            Console.WriteLine();
            Console.WriteLine("=== Part 6: Boxing and Unboxing Demo ===");
            Console.WriteLine();

            int number = 42;

            object boxed = number;        // Boxing: value type -> reference type
            int unboxed = (int)boxed;     // Unboxing: reference type -> value type

            Console.WriteLine($"Original int value: {number}");
            Console.WriteLine($"Boxed object value: {boxed}");
            Console.WriteLine($"Unboxed int value: {unboxed}");

            Console.WriteLine("Explanation: boxing creates an object wrapper around a value type.");
            Console.WriteLine("Modern C# often avoids unnecessary boxing by using generics.");
        }
    }
}
