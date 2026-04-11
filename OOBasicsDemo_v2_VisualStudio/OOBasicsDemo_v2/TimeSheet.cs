using System;

namespace OOBasicsDemo_v2
{
    /// <summary>
    /// TimeSheet class records overtime information.
    /// It collaborates with Employee through method calls.
    /// </summary>
    public class TimeSheet
    {
        /// <summary>
        /// Instruction message:
        /// performs an action and returns no value.
        /// Method signature:
        /// AddEntry(string employeeName, int hours) : void
        /// </summary>
        public void AddEntry(string employeeName, int hours)
        {
            Console.WriteLine($"Recorded that {employeeName} worked {hours} overtime hour(s).");
        }
    }
}
