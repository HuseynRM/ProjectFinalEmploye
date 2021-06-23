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
        
        List<Employee> employees { get; set; }

        public double CalcSalaryAverage(List<Employee> employee)
        {
            double resault = 0;
            double sum = 0;
            foreach (Employee item in employee)
            {
                sum += item.Salary;
            }
            resault = sum / employee.Count;
            return resault;
            //departamentdeki ishcilerin maashlarinin ortalama hesablanmasi:
        }
    }
}
