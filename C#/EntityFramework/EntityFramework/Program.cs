using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

var factory = new CookbookContextFactory();
using var context = factory.CreateDbContext(args);


var porridge = new Dish { Title = "Breakfast Porridge", Notes = "This Is Sooo Good!", Stars= 4 };


//Add an object to the database
context.Dishes.Add(porridge);
await context.SaveChangesAsync();

Console.WriteLine($"A dish ADDED\n" +
    $"\tId: {porridge.Id}\n" +
    $"\tTitle: {porridge.Title}\n" +
    $"\tNote: {porridge.Notes}\n" +
    $"\tStars: {porridge.Stars}\n");


//Update an object
porridge.Stars = 5;
await context.SaveChangesAsync();


//Read from database
var result = context
    .Dishes
    .Where(dish => dish.Title.Contains("porridge"))
    .ToList();

foreach (var x in result) Console.WriteLine(x.Id);
Console.WriteLine("\n");


//Removing the added object from the database
context.Dishes.Remove(porridge);
await context.SaveChangesAsync();

Console.WriteLine($"A dish REMOVED\n" +
    $"\tId: {porridge.Id}\n" +
    $"\tTitle: {porridge.Title}\n" +
    $"\tNote: {porridge.Notes}\n" +
    $"\tStars: {porridge.Stars}\n");

class Dish
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;

    public string? Notes { get; set; }

    public int? Stars { get; set; }

    public List<DishIngrediant> Ingrediants { get; set; } = new();
}

class DishIngrediant
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Description { get; set; } = string.Empty;

    [MaxLength(50)]
    public string UnitOfMesure { get; set; } = string.Empty;

    [Column(TypeName = "decimal(5,2)")]
    public decimal Amount { get; set; }

    public Dish? Dish { get; set; }

    public int DishId { get; set; }

}

class CookBookContext : DbContext
{
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<DishIngrediant> Ingredients { get; set; }
    public CookBookContext(DbContextOptions<CookBookContext> options)
        : base(options)
    {
    }

}

class CookbookContextFactory : IDesignTimeDbContextFactory<CookBookContext>
{
    public CookBookContext CreateDbContext(string[]? args = null)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        var optionsBuilder = new DbContextOptionsBuilder<CookBookContext>();
        optionsBuilder
             // Uncomment the following line if you want to print generated
             // SQL statements on the console.
             //.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

        return new CookBookContext(optionsBuilder.Options);
    }
}