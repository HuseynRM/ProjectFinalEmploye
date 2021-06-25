using ProjectFinalEmploye.interfaces;
using ProjectFinalEmploye.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectFinalEmploye.services
{
    //interface de olan methodlarin body hissesinii yazmaq ucun yaradilmish servis  clasi :
    class HumanResourceManager : IHumanResourceManager
    {
        public List<Department> departments { get ; set ; }
        public Department department { get; set; }
        public List<Employee> Employees { get; set; }

        public HumanResourceManager()
        {
            departments = new List<Department>();
            
        }

        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        public void GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void EditDepartaments()
        {
            throw new NotImplementedException();
        }

        public void AddEmployee()
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee()
        {
            throw new NotImplementedException();
        }

        public void EditEmploye()
        {
            throw new NotImplementedException();
        }
    }
}
