using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    class Employee 
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
    }

    class Person
    {
        public string PersonName { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpID=1, EmpName="Sujit", Job="Developer", City= "Nashik"},
                new Employee(){EmpID=2, EmpName="Sumit", Job="Developer", City= "Mumbai"},
                new Employee(){EmpID=3, EmpName="Vaishnavi", Job="Analyst", City= "Pune"},
                new Employee(){EmpID=4, EmpName="Gayatri", Job="Engineer", City= "Pune"},
                new Employee(){EmpID=5, EmpName="Om", Job="Engineer", City= "Andheri"}
            };

            //***   LINQ        ***

            //LAMDA Expression
            //Where
            //var result = employees.Where(emp => emp.Job =="Developer");
            //IEnumerable<Employee> result = employees.Where(emp => emp.Job =="Developer");

            //OrderBy or OrderByDescending
            //var result = employees.OrderBy(e => e.EmpName);

            //ThenBy or ThenByDescending
            //var result = employees.OrderBy(e => e.City).ThenBy(e => e.EmpID);

            //single / SingleorDefault
            //first / firstordefault

            /*foreach (Employee item in result)
            {
                Console.WriteLine(item.EmpID+", " +item.EmpName+ ", " + item.City);
            }*/


            //LINQ Select
/*            List<Person> result = employees.Select(emp => new Person() { PersonName = emp.EmpName }).ToList();

            foreach (Person item in result)
            {
                Console.WriteLine(item.PersonName);
            }*/

            //Min maz sum avg count
            //var result = employees.Min(e => e.EmpID);  
            //var result = employees.Max(e => e.EmpID);  
            //var result = employees.Sum(e => e.EmpID);  
            var result = employees.Average(e => e.EmpID);  

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
