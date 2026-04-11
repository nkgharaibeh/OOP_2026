namespace OOBasicsDemo_v2
{
    /// <summary>
    /// Employee class represents an employee object in the system.
    ///
    /// UML class diagram idea:
    /// -----------------------------------------
    /// Employee
    /// -----------------------------------------
    /// - name : string
    /// - username : string
    /// - currentLocation : Location
    /// - phoneNumber : string
    /// -----------------------------------------
    /// + Employee(...)
    /// + Employee()
    /// + Move(Location) : void
    /// + Email() : string
    /// + RecordOvertime(TimeSheet, int) : void
    /// + GetSummary() : string
    /// -----------------------------------------
    /// </summary>
    public class Employee
    {
        // Private fields = instance variables / attributes.
        // currentLocation shows a has-a relationship:
        // Employee has-a Location.
        private string name;
        private string username;
        private Location currentLocation;
        private string phoneNumber;

        /// <summary>
        /// Parameterized constructor used to initialize the object
        /// with full employee information.
        /// </summary>
        public Employee(string name, string username, Location currentLocation, string phoneNumber)
        {
            this.name = name;
            this.username = username;
            this.currentLocation = currentLocation;
            this.phoneNumber = phoneNumber;
        }

        /// <summary>
        /// Default constructor.
        /// Demonstrates constructor overloading.
        /// </summary>
        public Employee()
        {
            name = "Unknown Employee";
            username = "unknown";
            currentLocation = new Location("Not Assigned");
            phoneNumber = "N/A";
        }

        /// <summary>
        /// Changes the employee's current location.
        /// This changes the internal state of the object.
        /// </summary>
        public void Move(Location newLocation)
        {
            currentLocation = newLocation;
        }

        /// <summary>
        /// Returns the employee's email address.
        /// Method signature:
        /// Email() : string
        /// </summary>
        public string Email()
        {
            return username + "@example.com";
        }

        /// <summary>
        /// Demonstrates collaboration through messages.
        /// Employee uses-a TimeSheet temporarily through a parameter.
        /// </summary>
        public void RecordOvertime(TimeSheet timeSheet, int hours)
        {
            timeSheet.AddEntry(name, hours);
        }

        /// <summary>
        /// Returns a summary of the object state.
        /// </summary>
        public string GetSummary()
        {
            return $"Name: {name}, Username: {username}, Location: {currentLocation.GetName()}, Phone: {phoneNumber}";
        }
    }
}
