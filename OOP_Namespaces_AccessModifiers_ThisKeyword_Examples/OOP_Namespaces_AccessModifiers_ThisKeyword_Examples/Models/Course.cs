namespace OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Models
{
    /// <summary>
    /// Course is another model class in the same namespace as Student.
    ///
    /// Related slide idea:
    /// Classes that represent similar concepts can be grouped in the same namespace.
    /// </summary>
    public class Course
    {
        private string courseCode;
        private string courseTitle;

        public Course(string courseCode, string courseTitle)
        {
            this.courseCode = courseCode;
            this.courseTitle = courseTitle;
        }

        public string GetInfo()
        {
            return $"{courseCode} - {courseTitle}";
        }
    }
}
