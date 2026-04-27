namespace OOP_Encapsulation_Properties_Examples
{
    /// <summary>
    /// TimeSheet demonstrates a static property.
    ///
    /// Slide idea:
    /// Static members belong to the class itself, not to a specific object.
    /// MaxEntries is shared by all TimeSheet objects.
    /// </summary>
    public class TimeSheet
    {
        private static int maxEntries = 100;

        /// <summary>
        /// Static property encapsulating a static field.
        /// It can be accessed using the class name:
        /// TimeSheet.MaxEntries
        /// </summary>
        public static int MaxEntries
        {
            get { return maxEntries; }
            private set
            {
                if (value > 0)
                {
                    maxEntries = value;
                }
            }
        }

        public static void IncreaseMaxEntriesBy(int value)
        {
            MaxEntries = MaxEntries + value;
        }
    }
}
