﻿using System;
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

    internal class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){EmpID=1, EmpName="Sujit", Job="Developer", City= "Sinnar"},
                new Employee(){EmpID=2, EmpName="Sumit", Job="Developer", City= "Mumbai"},
                new Employee(){EmpID=3, EmpName="Vaishnavi", Job="Analyst", City= "Pune"},
                new Employee(){EmpID=4, EmpName="Gayatri", Job="Engineer", City= "Pune"},
                new Employee(){EmpID=5, EmpName="Om", Job="Engineer", City= "Andheri"}
            };
            
            //LAMDA Expression
            employees.Where(emp => emp.Job =="Developer");
        }
    }
}
