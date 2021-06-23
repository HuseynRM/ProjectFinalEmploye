using ProjectFinalEmploye.interfaces;
using ProjectFinalEmploye.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFinalEmploye.services
{
    class HumanResourceManager : IHumanResourceManager
    {
        public List<Department> departments { get ; set ; }
        public List<Employee> Employees { get; }

        public HumanResourceManager()
        {
            departments = new List<Department>();
            Employees = new List<Employee>();
        }
        public void AddDepartment(Department department)
        {
            
             departments.Add(department);
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void EditDepartaments()
        {
            throw new NotImplementedException();
        }

        public void EditEmploye()
        {
            throw new NotImplementedException();
        }

        public void GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
