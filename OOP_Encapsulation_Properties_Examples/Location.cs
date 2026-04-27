namespace OOP_Encapsulation_Properties_Examples
{
    /// <summary>
    /// Location is a simple class used by Employee.
    /// It helps show how a property can refer to another class type.
    /// </summary>
    public class Location
    {
        private string name;

        public Location(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
