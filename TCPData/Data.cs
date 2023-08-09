using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FirstName= "Bob",
                    LastName = "Jones",
                    AnnualSalary = 60000.3M,
                    IsManager = true,
                    DepartmentId = 1
                },
                new Employee()
                {
                    Id = 2,
                    FirstName= "Sarah",
                    LastName = "Jameson",
                    AnnualSalary = 80000.1M,
                    IsManager = true,
                    DepartmentId = 3
                },
                new Employee()
                {
                    Id = 3,
                    FirstName= "Douglas",
                    LastName = "Roberts",
                    AnnualSalary = 40000.2M,
                    IsManager = false,
                    DepartmentId = 2
                },
                new Employee()
                {
                    Id = 4,
                    FirstName= "Jane",
                    LastName = "Stevens",
                    AnnualSalary = 30000.2M,
                    IsManager = false,
                    DepartmentId = 1
                }
            };

            return employees;
    
        }

        public static List<Department> GetDepartments(IEnumerable<Employee> employees)
        {
            List<Department> departments = new List<Department>()
            {
                new Department() 
                { 
                    Id = 1,
                    ShortName = "HR",
                    LongName = "Human Resources",
                    Employees = from emp in employees
                                where emp.DepartmentId == 1
                                select emp
                },
                new Department()
                {
                    Id = 2,
                    ShortName = "FN",
                    LongName = "Finance",
                    Employees = from emp in employees
                                where emp.DepartmentId == 2
                                select emp

                },
                new Department()
                {
                    Id = 3,
                    ShortName = "TE",
                    LongName = "Technology",
                    Employees = from emp in employees
                                where emp.DepartmentId == 3
                                select emp
                }
            };

            return departments;
        }

        public static ArrayList GetHeterogeneousDataCollection()
        {
             ArrayList arrayList = new ArrayList();

            arrayList.Add(100);
            arrayList.Add("Bob Jones");
            arrayList.Add(2000);
            arrayList.Add(3000);
            arrayList.Add("Bill Henderson");
            arrayList.Add(new Employee { Id = 6, FirstName = "Jennifer", LastName = "Dale", AnnualSalary = 90000, IsManager = true, DepartmentId = 1 });
            arrayList.Add(new Employee { Id = 7, FirstName = "Dane", LastName = "Hugh", AnnualSalary = 60000, IsManager = true, DepartmentId = 1 });
            arrayList.Add(new Department { Id = 4, ShortName = "MKT", LongName = "Marketing",});
            arrayList.Add(new Department { Id = 5, ShortName = "R&D", LongName = "Research And Development" });
            arrayList.Add(new Department { Id = 6, ShortName = "PRD", LongName = "Production" });

            return arrayList;

        }
    }
}
