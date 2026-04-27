namespace OOP_Namespaces_AccessModifiers_ThisKeyword_Examples.Models
{
    /// <summary>
    /// Student is a model class.
    ///
    /// Related slide ideas:
    /// - A class is a named block of code.
    /// - A class contains fields, constructors, and methods.
    /// - Fields are usually private.
    /// - Public methods provide controlled access.
    /// - this keyword refers to the current object.
    ///
    /// UML-style view:
    /// -----------------------------------------
    /// Student
    /// -----------------------------------------
    /// - id : int
    /// - name : string
    /// - gpa : double
    /// -----------------------------------------
    /// + Student(int id, string name, double gpa)
    /// + UpdateGpa(double newGpa) : void
    /// + GetSummary() : string
    /// -----------------------------------------
    /// </summary>
    public class Student
    {
        // private means these fields can be used only inside this class.
        // They cannot be accessed directly from Program or other classes.
        private int id;
        private string name;
        private double gpa;

        /// <summary>
        /// Constructor.
        ///
        /// Notice that the parameter names are the same as the field names.
        ///
        /// this.id   means the field that belongs to the current object.
        /// id        means the parameter received by the constructor.
        /// </summary>
        public Student(int id, string name, double gpa)
        {
            this.id = id;
            this.name = name;
            this.gpa = gpa;
        }

        /// <summary>
        /// Public method that updates the private GPA field.
        /// </summary>
        public void UpdateGpa(double newGpa)
        {
            if (newGpa >= 0.0 && newGpa <= 4.0)
            {
                this.gpa = newGpa;
            }
            else
            {
                Console.WriteLine("Invalid GPA. GPA must be between 0.0 and 4.0.");
            }
        }

        /// <summary>
        /// Public method that returns a summary of the student.
        /// </summary>
        public string GetSummary()
        {
            return $"ID: {id}, Name: {name}, GPA: {gpa}";
        }
    }
}
