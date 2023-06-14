using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class SortingAList
    {
        public static void Main(string[] args)
        {
            List<int> ints= new List<int> { 1, 9, 2, 5, 3, 7, 10};
            List<string> strings = new List<string>();

            strings.Sort();
            ints.Sort(); // Ascending order
            ints.Reverse();

            List<Employee> employees = new List<Employee> { 
                new Employee() { Id= 1, Gender = "Male", Name = "Name1", Salary = 1523 },
                new Employee() { Id= 6, Gender = "Male", Name = "Name6", Salary = 2689 },
                new Employee() { Id= 4, Gender = "Male", Name = "Name4", Salary = 2368 },
                new Employee() { Id= 9, Gender = "Male", Name = "Name9", Salary = 2345 }
            };

            employees.Sort();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Name + ":" + employee.Salary);
            }
        }
    }

    class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee obj)
        {
            /*
             * > 0 = current instance is greater than the object being compared with
             * < 0 = current instance is less than the object being compared with
             * = 0 = current instance is equal than the object being compared with
             */

            if (this.Salary > obj.Salary)
            {
                return 1;
            } 
            else if (this.Salary < obj.Salary)
            {
                return -1;
            }

            return 0;
        }
    }
}
