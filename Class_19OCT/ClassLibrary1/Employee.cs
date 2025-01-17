using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(int empID, string name, string department, double sal)
        {
            EmpID = empID;
            Name = name;
            Department = department;
            Salary = sal;
        }

        public override string ToString()
        {
            return $"ID: {EmpID}, Name: {Name}, Department: {Department}, Salary: {Salary}";
        }
    }
}
