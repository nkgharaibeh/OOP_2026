using System;
using System.Collections.Generic;

namespace OOBasicsDemo_v3_DataTypes_Objects_References
{
    /// <summary>
    /// Department contains a List of Employee references.
    ///
    /// Important:
    /// List<Employee> stores references to Employee objects.
    /// The Employee objects themselves are reference-type objects.
    /// </summary>
    public class Department
    {
        private string name;
        private List<Employee> employees;

        public Department(string name)
        {
            this.name = name;
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void PrintEmployees()
        {
            Console.WriteLine($"Department: {name}");
            Console.WriteLine("Employees:");

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetSummary());
            }
        }
    }
}
