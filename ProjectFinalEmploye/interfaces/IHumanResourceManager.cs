using System;
using System.Collections.Generic;
using System.Text;
using ProjectFinalEmploye.models;

namespace ProjectFinalEmploye.interfaces
{
    interface IHumanResourceManager
    {
        // iterfacede yazilan methodlarin body hissesi olmadigi ucun yeni servis klasi yaradib  miras alib implement edirik.
        List<Department> departments { get; set; }
        void AddDepartment();
        void GetDepartments();
        void EditDepartaments();
        void AddEmployee();
        void RemoveEmployee();
        void EditEmploye();
        
    }
}
