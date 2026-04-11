namespace OOBasicsDemo_v2
{
    /// <summary>
    /// Location class represents a work location.
    /// It helps demonstrate the has-a relationship:
    /// Employee has-a Location.
    /// </summary>
    public class Location
    {
        private string name;

        public Location(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
