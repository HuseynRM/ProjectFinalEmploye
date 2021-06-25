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
        void AddEmployee();
        void RemoveEmployee();
        void EditEmploye();
        //interfade methodun body({}) hissesi olmmadiigindan servis classi yaradib interfaceni ora inhert edib implement edirik.
    }
}
