using System;
using System.Collections;
using TCPData;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

            //SORT OPERATORS
            //Method Sintax
            //var results = employeeList.Join(departmentList,
            //    e => e.DepartmentId,
            //    d => d.Id,
            //    (emp, dep ) => new
            //    {
            //        Id = emp.Id,
            //        FirstName = emp.FirstName,
            //        LastName = emp.LastName,
            //        AnnualSalary = emp.AnnualSalary,
            //        DepartmentId = dep.Id,
            //        DepartmentName = dep.LongName
            //    }).OrderBy( o => o.DepartmentName)
            //    .ThenByDescending(o => o.AnnualSalary);

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"Id: {item.Id,-5}, First Name: {item.FirstName,-10}, Last Name: {item.LastName,-10}, Annual Salary: {item.AnnualSalary,10}\tDepartment Name: {item.DepartmentName}  ");
            //}


            //QUERY SINTAX
            //var results = from emp in employeeList
            //              join dept in departmentList
            //              on emp.DepartmentId equals dept.Id
            //              orderby emp.DepartmentId, emp.AnnualSalary descending
            //              select new
            //              {
            //                  Id = emp.Id,
            //                  FirstName = emp.FirstName,
            //                  LastName = emp.LastName,
            //                  AnnualSalary = emp.AnnualSalary,
            //                  DepartmentId = dept.Id,
            //                  DepartmentName = dept.LongName
            //              };

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"Id: {item.Id,-5}, First Name: {item.FirstName,-10}, Last Name: {item.LastName,-10}, Annual Salary: {item.AnnualSalary,10}\tDepartment Name: {item.DepartmentName}  ");
            //}

            //GROUPING OPERATORS
            //var groupResult = from emp in employeeList
            //                  orderby emp.DepartmentId 
            //                  group emp by emp.DepartmentId;

            //foreach(var empGroup in groupResult)
            //{
            //    Console.WriteLine($"Department Id: {empGroup.Key}");

            //    foreach (Employee emp in empGroup)
            //    {
            //        Console.WriteLine($"\tEmployee FullName: { emp.FirstName } { emp.LastName }");
            //    }
            //}

            //ToLookUp Operator
            //var groupResult = employeeList.ToLookup(e => e.DepartmentId);

            //foreach (var empGroup in groupResult)
            //{
            //    Console.WriteLine($"Department Id: {empGroup.Key}");

            //    foreach (Employee emp in empGroup)
            //    {
            //        Console.WriteLine($"\tEmployee FullName: {emp.FirstName} {emp.LastName}");
            //    }
            //}

            ////QUANTIFY OPERATORS
            //var annualSalaryCompare = 20000;

            //bool isTrueAll = employeeList.All(e => e.AnnualSalary > annualSalaryCompare);

            //if(isTrueAll)
            //{
            //    Console.WriteLine($"All employee annual salaries are above {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"Not All employee annual salaries are above {annualSalaryCompare}");
            //}

            //bool isTrueAny = employeeList.Any(e => e.AnnualSalary > annualSalaryCompare);

            //if (isTrueAny)
            //{
            //    Console.WriteLine($"At least one employee has annual salarie above {annualSalaryCompare}");
            //}
            //else
            //{
            //    Console.WriteLine($"No employees have salaries are above {annualSalaryCompare}");
            //}

            ////CONTAINS OPERATOR
            //var searchEmployee = new Employee
            //{
            //    Id = 3,
            //    FirstName = "Douglas",
            //    LastName = "Roberts",
            //    AnnualSalary = 40000.2m,
            //    IsManager = false,
            //    DepartmentId = 2
            //};

            //bool containsEmployee = employeeList.Contains(searchEmployee, new EmployeeComparer());

            //if(containsEmployee)
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was found");
            //}
            //else
            //{
            //    Console.WriteLine($"An employee record for {searchEmployee.FirstName} {searchEmployee.LastName} was not found");
            //}

            //************FILTER OPERATORS***************


            //OFType filter Operator
            //ArrayList mixedCollection = Data.GetHeterogeneousDataCollection();
            //var employeeResults = from s in mixedCollection.OfType<Employee>()
            //                   select s;

            //foreach (var emp in employeeResults)
            //    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10}{emp.LastName,-10}");

            //var departmentResults = from d in mixedCollection.OfType<Department>()
            //                        select d;

            //foreach (var dep in departmentResults)
            //    Console.WriteLine($"{dep.Id,-5} {dep.LongName,-30}{dep.ShortName,-10}");

            ////ElementAt, ElementAtOrDefault
            //var employee = employeeList.ElementAtOrDefault(8);
            //if(employee != null)
            //{
            //    Console.WriteLine($"{employee.Id,-5} {employee.FirstName,-10}{employee.LastName,-10}");

            //}
            //else
            //{
            //    Console.WriteLine("This employee does not exist");
            //}

            ////First, FirstOrDefault, Last, LastOrDefault Operators
            //List<int> integerList = new List<int> { 3, 15, 23, 17, 29, 89 };

            //No condition, returns the first element of the list:
            //int result = integerList.First();

            //To avoid getting an exception when no item satisfies the condition we can use FirstOrDefault Operator
            //int result = integerList.First(i => i % 2 == 0);

            ////int result = integerList.FirstOrDefault(i => i % 2 == 0);



            ////Single o, SingleOrDefault Operators
            //List<int> integerList = new List<int> { 89 };
            //int result = integerList.Single();
            //Console.WriteLine(result);


            //var emp  = employeeList.Single(e => e.Id == 2 );

            //To avoid exception when no item on the list meets the condition we can use singleOrDefault
            //If more than one element on the list meets the condition defined by our predicate, an exception will be thrown.
            //var emp  = employeeList.SingleOrDefault(e => e.Id > 2 );


            //if(emp != null)
            //{
            //    Console.WriteLine($"{emp.Id,-5} {emp.FirstName,-10}{emp.LastName,-10}");
            //}
            //else
            //{
            //    Console.WriteLine("This employee does not exist within the collection");
            //}

            Console.ReadKey();
        }
    }
}