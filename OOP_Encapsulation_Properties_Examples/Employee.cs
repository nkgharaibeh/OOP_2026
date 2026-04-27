namespace OOP_Encapsulation_Properties_Examples
{
    /// <summary>
    /// Employee class demonstrates several property styles.
    ///
    /// This example follows the slide idea:
    ///
    /// Attribute       Property
    /// -------------------------------------------
    /// name            Name: get only
    /// username        Username: get only
    /// location        no property; changed by Move()
    /// phoneNumber     PhoneNumber: get and set
    /// none            Email: get; computed from username
    ///
    /// Key point:
    /// A property may encapsulate a field, or it may compute a value.
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

        /// <summary>
        /// Read-only property.
        /// The name can be read from outside the class, but cannot be changed directly.
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Read-only property.
        /// </summary>
        public string Username
        {
            get { return username; }
        }

        /// <summary>
        /// Read-write property.
        /// Other classes can read and change the phone number.
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Computed property.
        /// There is no private email field.
        /// The email is computed from the username.
        /// </summary>
        public string Email
        {
            get { return username + "@example.com"; }
        }

        /// <summary>
        /// Location is not changed through a public property.
        /// It is changed through a method because moving is a behavior/action.
        /// </summary>
        public void Move(Location newLocation)
        {
            currentLocation = newLocation;
        }

        public string GetSummary()
        {
            return $"Name: {Name}, Username: {Username}, Location: {currentLocation.Name}, Phone: {PhoneNumber}";
        }
    }
}
