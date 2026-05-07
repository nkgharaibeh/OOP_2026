using System;
namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// Location is also a reference type because it is a class.
    ///
    /// Employee has-a Location:
    /// private Location currentLocation;
    ///
    /// The Employee object stores a reference to a Location object.
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
