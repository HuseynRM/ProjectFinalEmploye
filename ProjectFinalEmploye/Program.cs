using ProjectFinalEmploye.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFinalEmploye
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Huseyn" ,"genceli" ,"goz hekimi",300,"onkologiya");
            Employee employee1 = new Employee("Ferid","memmedov", "goz hekimi", 300, "onkologiya");
            
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employee1.ToString());
        }
    }
}
