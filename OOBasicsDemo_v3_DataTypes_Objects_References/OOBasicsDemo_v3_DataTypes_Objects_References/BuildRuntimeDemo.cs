using System;

namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// Explains the build and runtime process conceptually.
    /// </summary>
    public static class BuildRuntimeDemo
    {
        public static void PrintBuildProcessSummary()
        {
            Console.WriteLine();
            Console.WriteLine("=== Part 7: Build Process, CLR, and JIT ===");
            Console.WriteLine();

            Console.WriteLine(".cs source code");
            Console.WriteLine("   ↓ compiled by C# compiler");
            Console.WriteLine("MSIL / IL");
            Console.WriteLine("   ↓ stored inside assembly");
            Console.WriteLine(".exe or .dll assembly");
            Console.WriteLine("   ↓ loaded by CLR");
            Console.WriteLine("JIT compiler translates IL to native machine code");
            Console.WriteLine("   ↓");
            Console.WriteLine("CPU executes the program");

            Console.WriteLine();
            Console.WriteLine("Visual Studio Build usually creates output in the bin folder.");
        }
    }
}
