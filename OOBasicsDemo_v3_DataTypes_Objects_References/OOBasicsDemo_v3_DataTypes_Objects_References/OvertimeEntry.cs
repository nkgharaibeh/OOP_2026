using System;
namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// struct is a value type.
    ///
    /// It can have fields, constructors, properties, and methods,
    /// but it behaves differently from a class when passed as a parameter.
    ///
    /// This struct represents a small value-like record.
    /// </summary>
    public struct OvertimeEntry
    {
        public string EmployeeName { get; }
        public int Hours { get; }
        public PayRate Rate { get; }

        public OvertimeEntry(string employeeName, int hours, PayRate rate)
        {
            EmployeeName = employeeName;
            Hours = hours;
            Rate = rate;
        }

        public string GetSummary()
        {
            return $"{EmployeeName}: {Hours} hour(s), Rate: {Rate}";
        }
    }
}
