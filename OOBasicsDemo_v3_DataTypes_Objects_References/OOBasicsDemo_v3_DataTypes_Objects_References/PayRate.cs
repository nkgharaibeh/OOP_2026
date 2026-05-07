using System;
namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// enum is a value type.
    ///
    /// It is useful when we need named constant values.
    /// This is better than using only bool isWeekend,
    /// because pay rate can have more than two cases.
    /// </summary>
    public enum PayRate
    {
        Normal,
        Weekend,
        Holiday
    }
}
