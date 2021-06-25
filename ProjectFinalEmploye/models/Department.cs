using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFinalEmploye.models
{
    class Department
    {
        public string Name { get; set; }
        public int WorkerLimit { get; set; }
        public double SalaryLimit { get; set; }
        
        public List<Employee> employees { get; set; }
        public object Employes { get; internal set; }

        public Department(string name, int workerlimit , double salarylimit)
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
        }
        public Department()
        {

        }

        public double CalcSalaryAverage(List<Employee> employees)
        {
            double resault = 0;
            double sum = 0;
            foreach (Employee item in employees)
            {
                sum += item.Salary;
            }
            resault = sum / employees.Count;
            return resault;
            //departamentdeki ishcilerin maashlarinin ortalama hesablanmasi:
        }
    }
}