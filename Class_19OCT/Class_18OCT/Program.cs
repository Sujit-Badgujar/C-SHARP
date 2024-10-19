using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_18OCT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>
            {
                new Employee(1,"Sujit", "IT", 900000),
                new Employee(2,"Sumit", "IT", 120000),
                new Employee(3,"Om", "IT", 100000),
                new Employee(4,"Gayatri", "IT", 130000),
                new Employee(5,"Vaish", "IT", 100000),
            };

            Console.WriteLine("Employees of Badgujar_Tech:");
            foreach (var employee in Employees) 
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
