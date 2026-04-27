namespace OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Utilities
{
    /// <summary>
    /// Printer is a utility class.
    ///
    /// Related slide ideas:
    /// - public class can be used by other parts of the program.
    /// - static methods can be called without creating an object.
    /// </summary>
    public class Printer
    {
        public static void PrintTitle(string title)
        {
            Console.WriteLine();
            Console.WriteLine("=== " + title + " ===");
        }
    }
}
