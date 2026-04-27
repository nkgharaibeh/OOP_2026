namespace OOP_Encapsulation_Properties_Examples
{
    /// <summary>
    /// Course demonstrates auto-implemented properties.
    ///
    /// This is a shorter modern C# style.
    /// The compiler creates the hidden backing fields automatically.
    ///
    /// This example can be used after students understand the long form:
    /// private field + get + set.
    /// </summary>
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }

        public Course(string courseCode, string courseName)
        {
            CourseCode = courseCode;
            CourseName = courseName;
        }

        public string GetInfo()
        {
            return $"{CourseCode} - {CourseName}";
        }
    }
}
