using System;
namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// Employee is a reference type because it is a class.
    ///
    /// Conceptual memory view:
    /// - The Employee object is created on the heap.
    /// - Variables such as emp1 store references to that object.
    /// - Passing Employee to a method copies the reference, not the whole object.
    /// </summary>
    public class Employee
    {
        private string name;
        private string username;
        private Location currentLocation;
        private string phoneNumber;

        public Employee(string name, string username, Location currentLocation, string phoneNumber)
        {
            this.name = name;
            this.username = username;
            this.currentLocation = currentLocation;
            this.phoneNumber = phoneNumber;
        }

        public Employee()
        {
            name = "Unknown Employee";
            username = "unknown";
            currentLocation = new Location("Not Assigned");
            phoneNumber = "N/A";
        }

        public void Move(Location newLocation)
        {
            currentLocation = newLocation;
        }

        public string Email()
        {
            return username + "@example.com";
        }

        /// <summary>
        /// Employee uses-a TimeSheet.
        ///
        /// Important for Chapter 4:
        /// timeSheet is a reference variable. When it is passed as a parameter,
        /// a copy of the reference is passed, but both references point to the same object.
        /// </summary>
        public void RecordOvertime(TimeSheet timeSheet, int hours, PayRate payRate)
        {
            timeSheet.AddEntry(name, hours, payRate);
        }

        public string GetSummary()
        {
            return $"Name: {name}, Username: {username}, Location: {currentLocation.GetName()}, Phone: {phoneNumber}";
        }
    }
}
