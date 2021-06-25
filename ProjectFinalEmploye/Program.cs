using ProjectFinalEmploye.models;
using ProjectFinalEmploye.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectFinalEmploye
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employe clasinin ishlemesine dair numune :

            //Employee employee = new Employee("Huseyn", "genceli", "goz hekimi", 300, "onkologiya");
            //Employee employee1 = new Employee("Ferid", "memmedov", "goz hekimi", 300, "onkologiya");

            //Console.WriteLine(employee.ToString());
            //Console.WriteLine(employee1.ToString());
            {
                HumanResourceManager humanResourceManager = new HumanResourceManager();
                do
                {
                    Console.WriteLine("Etmek Isdediyniz Emelliyyati Secin");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("1.1 Departamentlerin siyahisini gostermek");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("1.2 Departamenet yaratmaq");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("1.3 Departamentde deyisiklik etmek");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("2.1 Iscilerin siyahisini gostermek");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("2.2 Departamentdeki iscilerin siyahisini gostermek");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("2.3 Isci elave etmek");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("2.4 Isci uzerinde deyisiklik etmek");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("2.5 Departamentden isci silinmesi ");
                    Console.WriteLine("------------------------------------");
                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "1.1":
                            GetDepartment(humanResourceManager);
                            break;
                        case "1.2":
                            AddDepartment(humanResourceManager);
                            break;
                        case "1.3":
                            EditDepartment(humanResourceManager);
                            break;
                        case "2.1":
                            ShowEmployes(humanResourceManager);
                            break;
                        case "2.2":
                            ShowDepartmentEmployess(humanResourceManager);
                            break;
                        case "2.3":
                            AddEmploye(humanResourceManager);
                            break;
                        case "2.4":
                            Editemployee(humanResourceManager);
                            break;
                        case "2.5":
                            RemoveEmployee(humanResourceManager);
                            break;
                        default:
                            break;
                    }
                } while (true);
            }
        }
        public static void GetDepartment(HumanResourceManager humanResourceManager)
        {

            foreach (Department item in humanResourceManager.departments)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.employees.Count);
                Console.WriteLine(item.CalcSalaryAverage(item.employees));
            }
        }
        public static void AddDepartment(HumanResourceManager humanResourceManager)
        {
            bool nameloop = true;
            bool workerlimitloop = true;
            bool salarylimitloop = true;
            string departmentname = "";
            int departmentworkerlimit = 0;
            double departmentsalarylimit = 0;
            Console.WriteLine("Departmentin adin daxil edin");
            while (nameloop)
            {
                try
                {
                    departmentname = Console.ReadLine();
                    if (string.IsNullOrEmpty(departmentname) == false && departmentname.Length >= 2)
                    {
                        nameloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Duzgun ad daxil et");
                }
            }
            Console.WriteLine("Departmentin Workerlimitin daxil edin");
            while (workerlimitloop)
            {
                try
                {
                    departmentworkerlimit = int.Parse(Console.ReadLine());
                    if (departmentworkerlimit >= 1)
                    {
                        workerlimitloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Duzgun WorkerLimit daxil edin");
                }
            }
            Console.WriteLine("Departmentin Salarylimitin daxil edin");
            while (salarylimitloop)
            {
                try
                {
                    departmentsalarylimit = double.Parse(Console.ReadLine());
                    if (departmentsalarylimit >= 250)
                    {
                        salarylimitloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Duzgun SalaryLimit daxil edin");
                }
            }
            Department department = new Department(departmentname, departmentworkerlimit, departmentsalarylimit);
            humanResourceManager.AddDepartment(department);

        }
        public static void EditDepartment(HumanResourceManager humanresourcemanager)
        {

            string olddepartmentname = "";
            string newdepartmentname = "";
            int newworkerlimit = 0;
            double newsalarylimit = 0;
            bool oldloop = true;
            bool loop1 = true;
            bool loop2 = true;
            bool loop3 = true;
            Console.WriteLine("Deyisdirmek istediyiniz Departmentin adin daxil edin.");
            while (oldloop)
            {
                try
                {
                    olddepartmentname = Console.ReadLine();
                    Department department123 = humanresourcemanager.departments.Find(x => x.Name == olddepartmentname);
                    //bunu yoxla error ola biler!!!
                    if (department123 != null)
                    {
                        Console.WriteLine($"{department123.Name} {department123.WorkerLimit} {department123.SalaryLimit}");
                        Console.WriteLine("Departmentin yeni adin daxil edin.");
                        while (loop1)
                        {
                            try
                            {
                                newdepartmentname = Console.ReadLine();
                                if (string.IsNullOrEmpty(newdepartmentname) == false && newdepartmentname.Length >= 2)
                                {
                                    department123.Name = newdepartmentname;
                                    loop1 = false;
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Duzgun yeni ad daxil edin.");
                            }

                        }
                        Console.WriteLine("Departmentin yeni workerlimitin daxil edin.");
                        while (loop2)
                        {
                            try
                            {
                                newworkerlimit = int.Parse(Console.ReadLine());
                                if (newworkerlimit >= 2)
                                {
                                    department123.WorkerLimit = newworkerlimit;
                                    loop2 = false;
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Duzgun yeni workerlimit daxil edin.");
                            }
                        }
                        Console.WriteLine("Yeni SalaryLimit daxil edin.");
                        while (loop3)
                        {
                            try
                            {
                                newsalarylimit = double.Parse(Console.ReadLine());
                                if (newsalarylimit >= 250)
                                {
                                    department123.SalaryLimit = newsalarylimit;
                                    loop3 = false;
                                }
                                else
                                {
                                    throw new Exception();
                                }
                            }
                            catch (Exception)
                            {

                                Console.WriteLine("Duzgun Yeni salarylimit daxil edin.");
                            }
                        }
                        oldloop = false;

                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Duzgun Departmentin adin daxil edin.");
                }

            }


        }
        public static void ShowEmployes(HumanResourceManager humanresourcemanager)
        {
            foreach (Department item in humanresourcemanager.departments)
            {
                foreach (Employee employee in item.employees)
                {
                    Console.WriteLine(employee.No, employee.Fullname, employee.Salary, employee.DepartmentName);
                }
            }
        }
        public static void ShowDepartmentEmployess(HumanResourceManager humanresourcemanager)
        {
            Console.WriteLine("Iscilerin siyahisini gosdermek isdediyiniz departamentin adin yazin !!! ");
            string departmentname = Console.ReadLine();
            Department department = humanresourcemanager.departments.Find(n => n.Name == departmentname);
            foreach (Employee item in department.employees)
            {
                Console.WriteLine(item.No, item.Name, item.Position, item.Salary);
            }
        }
        public static void AddEmploye(HumanResourceManager humanresourcemanager)
        {
            Console.WriteLine("Yeni iscinin adin  elave edin : ");
            string newemployeename = Console.ReadLine();
            Console.WriteLine("yeni iscinin soyadini elave edin : ");
            string newemployeesurname = Console.ReadLine();
            string newemployeeposition = "";
            double newemployeesalary = 0;
            string newemplyoeedepartamentname = "";
            bool positionloop = true;
            bool departamentloop = true;
            bool salaryloop = true;
            bool nameloop = true;
            Console.WriteLine("Yeni iscinin vezifesini daxil edin ");
            while (positionloop)
            {
                try
                {
                    newemployeeposition = Console.ReadLine();
                    if (string.IsNullOrEmpty(newemployeeposition) == false && newemployeeposition.Length >= 2)
                    {
                        positionloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Duzgun yeni isci vezifesi daxil edin !!! ");
                }
            }
            Console.WriteLine("Yeni isci maasi daxil edin !!! ");
            while (salaryloop)
            {
                try
                {
                    newemployeesalary = double.Parse(Console.ReadLine());
                    if (newemployeesalary >= 250)
                    {
                        salaryloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Duzgun yeni maas daxil edin !!! ");
                }
            }
            Console.WriteLine("YEni iscinin departament adini daxil edin !!! ");
            while (departamentloop)
            {
                try
                {
                    newemplyoeedepartamentname = Console.ReadLine();
                    if (string.IsNullOrEmpty(newemplyoeedepartamentname) == false && newemplyoeedepartamentname.Length >= 2)
                    {
                        Department newemployedepartment = humanresourcemanager.departments.Find(a => a.Name == newemplyoeedepartamentname);
                        departamentloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Duzgun yeni departament adi daxil edin !!! ");
                }
            }
            Department department = humanresourcemanager.departments.Find(a => a.Name == newemployeename);
            Employee newemployee = new Employee(newemployeename, newemployeesurname, newemployeeposition, newemployeesalary, newemplyoeedepartamentname);
            department.employees.Add(newemployee);
        }

        public static void Editemployee(HumanResourceManager humanresourcemanager)
        {
            bool noloop = true;
            bool editsalary = true;
            bool newsalaryloop = true;
            bool newpositionloop = true;
            string editno = "";
            double newsalary = 0;
            string newposition = "";

            Console.WriteLine("deyishmek isdediyiniz iscinin Nomresini yazin!!!");
            while (noloop)
            {
                try
                {
                    editno = Console.ReadLine();
                    foreach (Department item in humanresourcemanager.departments)
                    {
                        Employee currentempoyee = item.employees.Find(a => a.No == editno);
                        if (currentempoyee != null)
                        {
                            Console.WriteLine($"{currentempoyee.Fullname} {currentempoyee.Salary} {currentempoyee.Position}");
                            Console.WriteLine("iscinin yeni maasini daxil edin ");
                            while (editsalary)
                            {
                                try
                                {
                                    newsalary = double.Parse(Console.ReadLine());
                                    if (newsalary >= 250)
                                    {
                                        currentempoyee.Salary = newsalary;
                                        newsalaryloop = false;
                                    }
                                    else
                                    {
                                        throw new Exception();
                                    }
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("Duzgun iscinin maasini daxil edin !!! ");
                                }
                            }
                            Console.WriteLine("Iscinin yeni vezifesini daxil edin !!! ");
                            while (newpositionloop)
                            {
                                try
                                {
                                    newposition = Console.ReadLine();
                                    if (string.IsNullOrEmpty(newposition) == false && newposition.Length >= 2)
                                    {
                                        currentempoyee.Position = newposition;
                                        newpositionloop = false;
                                    }
                                    else
                                    {
                                        throw new Exception();
                                    }
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("iscinin yeni vezifesini daxil edin!!!");
                                }
                            }
                        }
                        else
                        {
                            noloop = false;
                        }
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("iscinin duzgun nomresini daxil edin !!!");
                }
            }

        }
        public static void RemoveEmployee(HumanResourceManager humanResourceManager)
        {
            string departmentname = "";
            string employeeno = "";
            bool nameloop = true;
            bool noloop = true;
            Console.WriteLine("departmentin adin daxil edin");
            while (nameloop)
            {
                try
                {
                    departmentname = Console.ReadLine();
                    if (string.IsNullOrEmpty(departmentname) == false && departmentname.Length >= 2)
                    {
                        Department removedepartment = humanResourceManager.departments.Find(x => x.Name == departmentname);
                        while (noloop)
                        {
                            try
                            {
                                employeeno = Console.ReadLine();
                                foreach (Department item in humanResourceManager.departments)
                                {
                                    Employee removeemploye = item.employees.Find(x => x.No == employeeno);
                                    if (removeemploye != null)
                                    {
                                        removedepartment.employees.Remove(removeemploye);
                                        noloop = false;
                                    }
                                    else
                                    {
                                        throw new Exception();
                                    }
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Duzgun nomre daxil edin.");
                            }
                        }
                        nameloop = false;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Department adin duzgun daxil edin.");
                }
            }

        }
    }
}