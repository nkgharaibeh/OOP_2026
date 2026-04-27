namespace OOP_Encapsulation_Properties_Examples
{
    /// <summary>
    /// Bad example:
    /// This class uses public fields directly.
    ///
    /// Slide idea:
    /// Without encapsulation, other classes can change data freely,
    /// even to invalid values.
    /// </summary>
    public class BadStudent
    {
        public string Name;
        public double GPA;
    }
}
