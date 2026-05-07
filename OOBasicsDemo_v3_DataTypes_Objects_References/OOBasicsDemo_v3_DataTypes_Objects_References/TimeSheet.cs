using System;
namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// TimeSheet is a class, so it is a reference type.
    /// It demonstrates:
    /// - method parameters
    /// - enum parameter
    /// - simple business rule
    /// </summary>
    public class TimeSheet
    {
        public void AddEntry(string employeeName, int hours, PayRate payRate)
        {
            double multiplier = GetMultiplier(payRate);
            double paidHours = hours * multiplier;

            Console.WriteLine($"{employeeName} worked {hours} hour(s) with {payRate} rate. Paid hours = {paidHours}");
        }

        private double GetMultiplier(PayRate payRate)
        {
            if (payRate == PayRate.Weekend)
            {
                return 2.0;
            }

            if (payRate == PayRate.Holiday)
            {
                return 2.5;
            }

            return 1.0;
        }
    }
}
