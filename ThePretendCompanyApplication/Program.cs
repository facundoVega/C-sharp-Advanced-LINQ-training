﻿using System;
using TCPData;
using TCPExtensions;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList =   Data.GetEmployees();
            List<Department> departmentList  = Data.GetDepartments();

            var resultList = from emp in employeeList
                             join dept in departmentList
                             on emp.DepartmentId equals dept.Id
                             select new
                             {
                                 FirstName = emp.FirstName,
                                 LastName = emp.LastName,
                                 AnnualSalary = emp.AnnualSalary,
                                 Manager = emp.IsManager,
                                 Department = dept.LongName

                             };
            foreach (var employee in resultList)
            {
                Console.WriteLine($"First Name: {employee.FirstName} ");
                Console.WriteLine($"Last Name: {employee.LastName} ");
                Console.WriteLine($"Annual Salary: {employee.AnnualSalary} ");
                Console.WriteLine($"Manager: {employee.Manager} ");
                Console.WriteLine($"Deparment: {employee.Department}");
            }

            var averageAnnualSalary = resultList.Average(a => a.AnnualSalary);
            var highestAnnualSalary = resultList.Max(a => a.AnnualSalary);
            var lowestAnnualSalary = resultList.Min(a => a.AnnualSalary);

            Console.WriteLine($"Average Annual Salary: { averageAnnualSalary }");
            Console.WriteLine($"Highest Annual Salary: { highestAnnualSalary }");
            Console.WriteLine($"Lowest Annual Salary: { lowestAnnualSalary }");

            Console.ReadKey();
        }
    }
}