using System;
using System.Collections.Generic;
using System.Text;
using ProjectFinalEmploye.models;

namespace ProjectFinalEmploye.interfaces
{
    interface IHumanResourceManager
    {
        List<Department> departments { get; set; }
        void AddDepartment(Department department);
        void GetDepartments();
        void EditDepartaments();
        void AddEmployee(Employee employee);
        void RemoveEmployee();
        void EditEmploye();
    }
}
