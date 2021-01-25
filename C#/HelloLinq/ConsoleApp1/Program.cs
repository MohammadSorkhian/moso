using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using ConsoleApp1;

var fileContent = await File.ReadAllTextAsync(@"C:\Users\moham\Desktop\moso\C#\HelloLinq\ConsoleApp1\DATA0.json");
var cars = JsonSerializer.Deserialize<CarData[]>(fileContent);

//// Cars with at least four doors
//var carsWithAtLeastFourDoors = cars.Where(car => car.NumberOfDoors >= 4);
//foreach (var car in carsWithAtLeastFourDoors) Console.WriteLine(car.Make + " " + car.Model);

//// Cars that their maker's name starts with "M"
//cars.Where(car => car.Make.StartsWith("M"))
//    .Select(car => $"{car.Make} - {car.Model}")
//    .ToList()
//    .ForEach(car => global::System.Console.WriteLine(car)) ;

//// 10 most powerful cars
//cars.OrderByDescending(car => car.HP)
//    .Take(10)
//    .ToList()
//    .ForEach(car => global::System.Console.WriteLine($"{car.Model} - {car.HP}"));

//// number of models for each make after 1995
//cars.Where(car => car.Year >= 1995)
//    .GroupBy(car => car.Make)
//    .Select(c => new { c.Key, NumberOfModels = c.Count()})
//    .ToList()
//    .ForEach(item => global::System.Console.WriteLine($"{item.Key} : {item.NumberOfModels}"));

//// makers that have at leaast 2 models with >= 400hp
//cars.Where(car => car.HP > 400)
//    .GroupBy(car => car.Make)
//    .Select(car => new { make = car.Key, NumOfPowerfulCars = car.Count()})
//    .Where(item => item.NumOfPowerfulCars >=2)
//    .ToList()
//    .ForEach(item => global::System.Console.WriteLine(item.make));

////How many makes build cars with hp in ranges of 0-100, 101-200, 201-300, 301-400, 401-500
//cars.GroupBy(car => car.HP switch
//{
//    <= 100 => "0-100",
//    <= 200 => "101-200",
//    <= 300 => "201-300",
//    <= 400 => "301-400",
//    <= 500 => "401-500"
//}).Select(group => new
//{
//    range = group.Key,
//    numberOfMakersInEachRange = group.Select(item => item.Make).Distinct().Count()
//}).ToList()
//.ForEach(c => global::System.Console.WriteLine(c.range + " " + c.numberOfMakersInEachRange));

//cars
//    .OrderBy(car => car.Year).Take(10)
//    .ToList()
//    .ForEach(c => Console.WriteLine($"{c.Make}-{c.Model}-{c.Year}-{c.NumberOfDoors}"));

//Console.WriteLine("-------------");

//cars
//    .Where(c => c.HP > 496)
//    .ToList()
//    .ForEach(c => Console.WriteLine($"{c.Make}-{c.Model}-{c.Year}-{c.NumberOfDoors}-{c.HP}"));

//Console.WriteLine("-------------");

//var num = new List<int> { 10, 50, 20, 30, 40, 50, 60 };
//num.TakeWhile(n => n < 40).ToList().ForEach(x => Console.WriteLine(x));

//var ccc = cars.ToLookup(c => c.Make);
//ccc.ToList().ForEach(kvp => ccc[kvp.Key].ToList().ForEach(car => Console.WriteLine($"{car.Make} - {car.Model}")));
//ccc.SelectMany(kvp => ccc[kvp.Key], (kvp, CarList) => Console.WriteLine($"{kvp.Key} + {CarList.Model}")); //I don't know why it does not work. It should givw an output as above

//cars
//    .TakeWhile(c => c.HP > 4)
//    .ToList()
//    .ForEach(c => Console.WriteLine($"{c.Make}-{c.Model}-{c.Year}-{c.NumberOfDoors}-{c.HP}"));

////top 10 most powerful model
//cars.OrderByDescending(c => c.HP).Take(10).ToList().ForEach(x => Console.WriteLine($"{x.Make} - {x.Model}"));

////number of models per make that appears after 1995
//cars.Where(c=>c.Year>1995).GroupBy(c => c.Make).Select(c => new { c.Key, numModelsPerMake = c.Count() }).ToList().ForEach(i => Console.WriteLine($"{i.Key} has {i.numModelsPerMake} model(s)"));

////number of models per make that appears after 2008 and show maker that has no model in this criteria with zero
//cars.GroupBy(c => c.Make).Select(c => new { c.Key, numModelsPerMake = c.Where(y=>y.Year>2008).Count() }).ToList().ForEach(i => Console.WriteLine($"{i.Key} has {i.numModelsPerMake} model(s)"));

////List of makes that have at least 2 models with >= 400hp
//cars.Where(c => c.HP > 400).GroupBy(c => c.Make).Select(i => new { i.Key, num = i.Count() }).Where(i => i.num >= 2).ToList().ForEach(x => Console.WriteLine($"{x.Key} has {x.num}"));

////Display average HP per make
//cars.GroupBy(c => c.Make)
//    .Select(item => new { item.Key, avrg = item.Select(hp => hp.HP).Average() })
//    .ToList()
//    .ForEach(i => Console.WriteLine($"{i.Key} has average of {Math.Round(i.avrg,1)} hp"));


List<Student> listStudent = new List<Student>
{
new Student() { name = "s1", subjects = new List<string> { "a", "b" } },
new Student() { name = "s2", subjects = new List<string> { "c", "d" } }
};

//listStudent.SelectMany(s => s.subjects).ToList().ForEach(x => Console.WriteLine(x));
//listStudent.SelectMany(s => s.subjects, (st, sub) => new { st.name, sub }).ToList().ForEach(st_sub => Console.WriteLine($"{st_sub.name} has {st_sub.sub}"));
//listStudent.ToList().ForEach(item => item.subjects.ToList().ForEach(sub => Console.WriteLine($"{item.name} has {sub}"))); //This is equal above


var ListOfDepartments = new List<Department>()
{
new Department() { id = 1, Name = "IT" },
new Department() { id = 2, Name = "Software" },
//new Department() { id = 3, Name = "HR"}
};

var ListOfEmployees = new List<Employee>
{
    new Employee{ ID=1, Name="Jimi", DepartmentID=2, Type="PartTime"},
    new Employee{ ID=2, Name="Jack", DepartmentID=2, Type="PartTime"},
    new Employee{ ID=3, Name="Jons", DepartmentID=2, Type="PartTime"},
    new Employee{ ID=4, Name="KImi", DepartmentID=1, Type="PartTime"},
    new Employee{ ID=5, Name="Moso", DepartmentID=1 ,Type="PartTime"},
    new Employee{ ID=6, Name="Neda", DepartmentID=1, Type="PartTime"},
    new Employee{ ID=7, Name="Amir", DepartmentID=1 ,Type="PartTime"},
    new Employee{ ID=8, Name="Ashkan", DepartmentID=1, Type="FullTime"},
    new Employee{ ID=9, Name="Andrew", DepartmentID=1, Type="FullTime"},
    new Employee{ ID=10, Name="David", Type="FullTime"},
};

//var DepartmentEployees = ListOfDepartments
//    .GroupJoin(ListOfEmployees, d => d.id, e => e.DepartmentID, (dep, emps) => new { department = dep, employeesList = emps });
//foreach(var item in DepartmentEployees)
//{
//    Console.WriteLine(item.department.Name);
//    foreach(var emp in item.employeesList)
//    {
//        Console.WriteLine("\t" + emp.Name);
//    }
//    Console.WriteLine("\n");
//}

//ListOfEmployees.Join(ListOfDepartments, e => e.DepartmentID, d => d.id, (emp, dep)=> new { employeeName = emp.Name, departmentName = dep.Name })
//    .ToList()
//    .ForEach( pair => Console.WriteLine(pair.employeeName + "  " + pair.departmentName));

//var EmployeeDepartments = ListOfEmployees
//    .GroupJoin(ListOfDepartments, d => d.DepartmentID, e => e.id, (emp, deps) => new { employee = emp, departmentList = deps })
//    .SelectMany( s => s.departmentList.DefaultIfEmpty(), 
//    (item, defaultIfemptyResult) => new { empoyee = item.employee, departmentList = defaultIfemptyResult == null? "No department" : defaultIfemptyResult.Name});
//foreach (var item in EmployeeDepartments)
//{
//        Console.WriteLine(item.empoyee.Name + "\t" + item.departmentList);
//}

//var crossJoin = ListOfEmployees.SelectMany(e => ListOfDepartments, ( e, d) => new { e,d});
//foreach(var x in crossJoin)
//{
//    Console.WriteLine(x.e.Name + "\t" + x.d.Name);
//}



class Student
{
    public string name { get; set; }
    public List<string> subjects { get; set; }
}




class CarData
{
    [JsonPropertyName("id")]
    public int ID { get; set; }

    [JsonPropertyName("car_maker")]
    public string Make { get; set; }

    [JsonPropertyName("car_models")]
    public string Model { get; set; }

    [JsonPropertyName("car_year")]
    public int Year { get; set; }

    [JsonPropertyName("number_of_doors")]
    public int NumberOfDoors { get; set; }

    [JsonPropertyName("hp")]
    public int HP { get; set; }

}



