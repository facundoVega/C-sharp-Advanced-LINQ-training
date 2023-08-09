using System;
using TCPData;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments(employeeList);

            ////Equality Operator
            /////SequenceEqual
            //var integerList1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            //var integerList2 = new List<int> { 1, 2, 3, 4, 5, 6, };

            //var boolSequenceEqual = integerList1.SequenceEqual(integerList2);

            //Console.WriteLine(boolSequenceEqual);
            //var employeeListCompare = Data.GetEmployees();
            //var boolSequenceEqual = employeeList.SequenceEqual(employeeListCompare, new EmployeeComparer());

            //Console.WriteLine(boolSequenceEqual);

            ////Concatenation operator
            /////Concat
            //List<int> integerList1 = new List<int> { 1, 2, 3, 4 };
            //List<int> integerList2= new List<int> { 5, 6, 7, 8, 9, 10 };
            //IEnumerable<int> integerListConcat = integerList1.Concat(integerList2);

            //foreach (var item in integerListConcat)
            //    Console.WriteLine(item);

            //List<Employee> employeeList2 = new List<Employee>
            //{
            //    new Employee { Id = 5, FirstName = "Tony", LastName = "Stark"},
            //    new Employee { Id = 5, FirstName = "Debbie", LastName = "Townsend"},
            //};

            //IEnumerable<Employee> results = employeeList.Concat(employeeList2);

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName, -10}");

            ////Agregate Operators
            //decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0, (totalAnnualSalary, e) => {
            //    var bonus = e.IsManager ? 0.04m : 0.02m;
            //    totalAnnualSalary = (e.AnnualSalary + (e.AnnualSalary * bonus)) + totalAnnualSalary;

            //    return totalAnnualSalary;
            //});

            //Console.WriteLine($"Total Annual Salary of all employes (including bonues): { totalAnnualSalary  }");

            //string data = employeeList.Aggregate<Employee, string, string>("Emlpoyee Anual Salaries (including bonus):",
            //    (s, e) => {
            //        var bonus = e.IsManager ? 0.04m : 0.02m;

            //        s += $"{e.FirstName} {e.LastName} - {e.AnnualSalary + (e.AnnualSalary * bonus)}, ";
            //        return s;
            //    }, s => s.Substring(0, s.Length -2));

            //Console.WriteLine(data);

            ////Average
            //decimal average = employeeList.Average(e => e.AnnualSalary);
            //Console.WriteLine($"Average Annual Salary: {average}");

            //decimal average = employeeList.Where(e => e.DepartmentId == 3).Average(e => e.AnnualSalary);
            //Console.WriteLine($"Average Annual Salary (Technology department): { average }");

            ////COUNT
            //int countEmployees = employeeList.Count();
            //Console.WriteLine($"Number of employees: { countEmployees }");

            //int tecnoEmployees = employeeList.Count(e => e.DepartmentId == 3);

            //Console.WriteLine($"Number of Employees (Technology Department): { tecnoEmployees }");

            ////SUM
            //decimal result = employeeList.Sum(e => e.AnnualSalary );
            //Console.WriteLine($"Total Annual Salary: { result }");

            ////MAX
            //var result = employeeList.Max(e => e.AnnualSalary);
            //Console.WriteLine($"Highest Annual Salary: { result }");

            ////Generation Operators - DefaultIfEmpty, Empty, Range, Repeat
            //DefaultIfEmpty
            //List<int> intList = new List<int>();
            //var newList = intList.DefaultIfEmpty();

            //Console.WriteLine(newList.ElementAt(0));

            //List<Employee> employees = new List<Employee>();
            //var newList = employees.DefaultIfEmpty(new Employee { Id = 0 });

            //var result = newList.ElementAt(0);

            //if (result.Id == 0)
            //    Console.WriteLine($"The list is empty");

            ////EMPTY
            //List<Employee> emptyEmployeeList = Enumerable.Empty<Employee>().ToList();

            //emptyEmployeeList.Add(new Employee { Id = 7, FirstName = "Dan", LastName = "Brown"});

            //foreach (var item in emptyEmployeeList)
            //    Console.WriteLine($"{ item.FirstName } { item.LastName }");

            ////RANGE
            //var intCollection = Enumerable.Range(25, 20);

            //foreach (var item in intCollection)
            //    Console.WriteLine(item);

            ////REPEAT
            //var strCollection = Enumerable.Repeat<string>("Placeholder", 10);
            //foreach (var item in strCollection)
            //    Console.WriteLine(item);

            ////Set Operators -Distinct, Except, Intersect, Union
            ////Distinct
            //List<int> list = new List<int> { 1, 2, 1, 4, 6, 2, 6, 7, 8, 7, 7, 7};
            //var results = list.Distinct();
            //foreach(var item in results)
            //        Console.WriteLine(item);

            ////EXCEPT

            //IEnumerable<int> collection1 = new List<int> { 1, 2, 3, 4};
            //IEnumerable<int> collection2 = new List<int> { 3, 4, 5, 6 };

            //var results = collection1.Except(collection2);
            //foreach (var item in results)
            //    Console.WriteLine(item);

            //List<Employee> employeeList2 = new List<Employee>()
            //{
            //     new Employee()
            //    {
            //        Id = 1,
            //        FirstName= "Bob",
            //        LastName = "Jones",
            //        AnnualSalary = 60000.3M,
            //        IsManager = true,
            //        DepartmentId = 1
            //    },
            //    new Employee()
            //    {
            //        Id = 2,
            //        FirstName= "Sarah",
            //        LastName = "Jameson",
            //        AnnualSalary = 80000.1M,
            //        IsManager = true,
            //        DepartmentId = 3
            //    },
            //    new Employee()
            //    {
            //        Id = 3,
            //        FirstName = "Craig",
            //        LastName = "Laurence",
            //        AnnualSalary = 20000.2m,
            //        IsManager = false,
            //        DepartmentId = 1
            //    },
            //    new Employee()
            //    {
            //        Id = 4,
            //        FirstName = "Douglas",
            //        LastName = "Robert",
            //        AnnualSalary = 40000.2m,
            //        IsManager = false,
            //        DepartmentId = 1
            //    }

            //};

            //var results = employeeList.Except(employeeList2, new EmployeeComparer());

            ////Intersect
            //var results = employeeList.Intersect(employeeList2, new EmployeeComparer());

            //UNION
            //var results = employeeList.Union(employeeList2, new EmployeeComparer());

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,10} {item.LastName, -10}");

            ////Partitioning Operators - Skip, SkipWhile, Take, TakeWhile
            ////Skip
            //var results = employeeList.Skip(2);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////SKIPWHILE
            //employeeList.Add(new Employee { Id = 5, FirstName = "Same", LastName = "Davis", AnnualSalary = 100000});

            //var results = employeeList.SkipWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            //TAKE
            //var results = employeeList.Take(2);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////TakeWhile
            //var results = employeeList.TakeWhile(e => e.AnnualSalary > 50000);
            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10}");

            ////Conversion Operators  ToList, ToDictionary, ToArray
            ////ToDictionary


            //Dictionary<int, Employee> dictionary = (from emp in employeeList
            //                                       where emp.AnnualSalary > 50000
            //                                       select emp).ToDictionary<Employee, int>(e => e.Id);

            //foreach (var key in dictionary.Keys)
            //    Console.WriteLine($"Key: { key }, Value: { dictionary[key].FirstName } {dictionary[key].LastName }");

            //ToArray
            //Employee[] results = (from emp in employeeList
            //                                        where emp.AnnualSalary > 50000
            //                                        select emp).ToArray();

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary}");

            //LET CLAUSE AND INTO CLAUSE
            //var results = from emp in employeeList
            //              let Initials = emp.FirstName.Substring(0, 1).ToUpper() + emp.LastName.Substring(0, 1).ToUpper()
            //              let AnnualSalaryPlusBonus = (emp.IsManager) ? emp.AnnualSalary + (emp.AnnualSalary * 0.04m) : emp.AnnualSalary + (emp.AnnualSalary * 0.02m)
            //              where Initials == "JS" || Initials == "SJ" && AnnualSalaryPlusBonus > 50000
            //              select new
            //              {
            //                  Initials = Initials,
            //                  FullName = emp.FirstName + " " + emp.LastName,
            //                  AnnualSalaryPlusBonus = AnnualSalaryPlusBonus,
            //              };


            //foreach (var item in results)
            //    Console.WriteLine($"{item.Initials,-5} {item.FullName,-20}  {item.AnnualSalaryPlusBonus,10}");

            ////into
            //var results = from emp in employeeList
            //              where emp.AnnualSalary > 50000
            //              select emp
            //              into HighEarners
            //              where HighEarners.IsManager == true
            //              select HighEarners;

            //foreach (var item in results)
            //    Console.WriteLine($"{item.Id,-5} {item.FirstName, -10} {item.LastName,-10} {item.AnnualSalary,10}");

            ////Projection Operators - Select, SelectMany
            ////SELECT
            //var results = departmentList.Select(d => d.Employees);

            //foreach (var items in results)
            //    foreach (var item in items)
            //        Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");


            ////SelectMany
            var results = departmentList.SelectMany(d => d.Employees);

            foreach (var item in results)
                    Console.WriteLine($"{item.Id,-5} {item.FirstName,-10} {item.LastName,-10} {item.AnnualSalary,10}");

            Console.ReadKey();
        }
    }
}