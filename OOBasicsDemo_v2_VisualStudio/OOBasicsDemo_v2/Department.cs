using System;
using System.Collections.Generic;

namespace OOBasicsDemo_v2
{
    /// <summary>
    /// Department contains a collection of Employee objects.
    /// This demonstrates a has-a / aggregation-style relationship.
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

            // Demonstrates iteration inside a method.
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.GetSummary());
            }
        }
    }
}
