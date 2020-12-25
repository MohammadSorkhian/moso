using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

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


