using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFinalEmploye.models
{
    class Employee
    {
       
        public int No;
        public static int Count { get; set; } = 1000;
        public string Name { get; set; }
        public string Fullname;

        public string Surname { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }
        public Employee()
        {
            Count++;
            No = Count;
           
        }
        public Employee(string name, string surname, string position, double salary, string departamentname):this()
        {
            Name = name;
            Surname = surname;
            Position = position;
            Salary = salary;
            DepartmentName = departamentname;
            Fullname = name + " " + surname;
            //fullname name ve surnameni qaytarmasi ucun kostraktorda assign etdim.
        }

        public override string ToString()
        {
            return $"{No} {Fullname} {Position} {Salary} {DepartmentName}";
        }

    }
}
