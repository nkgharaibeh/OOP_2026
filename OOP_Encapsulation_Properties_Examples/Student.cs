namespace OOP_Encapsulation_Properties_Examples
{
    /// <summary>
    /// Student class demonstrates encapsulation using private fields and public properties.
    ///
    /// Slide connection:
    /// - Classes usually contain private fields.
    /// - Sometimes other classes need to read or change the values.
    /// - C# provides properties to encapsulate private fields.
    ///
    /// UML-style view:
    /// -------------------------------------
    /// Student
    /// -------------------------------------
    /// - id : int
    /// - name : string
    /// - gpa : double
    /// -------------------------------------
    /// + Id : int { get }
    /// + Name : string { get; set; }
    /// + GPA : double { get; set with validation }
    /// + GetSummary() : string
    /// -------------------------------------
    /// </summary>
    public class Student
    {
        // Private fields represent the internal state of the object.
        private int id;
        private string name;
        private double gpa;

        public Student(int id, string name, double gpa)
        {
            this.id = id;
            this.name = name;

            // Use the property instead of the field to apply validation.
            GPA = gpa;
        }

        /// <summary>
        /// Read-only property.
        /// The student ID can be read, but cannot be changed from outside the class.
        /// </summary>
        public int Id
        {
            get { return id; }
        }

        /// <summary>
        /// Read-write property.
        /// Other classes can read and change the student's name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Property with validation.
        ///
        /// The field gpa is private, but the public property controls access to it.
        /// This protects the object from invalid values.
        /// </summary>
        public double GPA
        {
            get { return gpa; }

            set
            {
                if (value >= 0.0 && value <= 4.0)
                {
                    gpa = value;
                }
                else
                {
                    Console.WriteLine("Invalid GPA value. GPA must be between 0.0 and 4.0.");
                }
            }
        }

        public string GetSummary()
        {
            return $"Student ID: {Id}, Name: {Name}, GPA: {GPA}";
        }
    }
}
