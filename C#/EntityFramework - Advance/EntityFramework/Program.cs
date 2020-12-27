using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


var factory = new CookbookContextFactory();
using var dbContext = factory.CreateDbContext(args);


Console.WriteLine("Different STATUS of an Object are as following:\n");
var newDish = new Dish { Title = "Foo", Notes = "Bar" };
Console.WriteLine($"just created an Obj: {dbContext.Entry(newDish).State}");

dbContext.Dishes.Add(newDish);
Console.WriteLine($"added the object: {dbContext.Entry(newDish).State}");

//If we change the state of an entry
dbContext.Entry(newDish).State = EntityState.Detached;
Console.WriteLine($"set the state to DETACHED: {dbContext.Entry(newDish).State}\n");


var dishes = await dbContext.Dishes.ToArrayAsync();
Console.WriteLine($"read from Database without AsNoTracking(): {dbContext.Entry(dishes[0]).State}");


//In cases that we just read the database and do not intend to make any changes we should use AsNoTracking() option
var dishesNoTracking = await dbContext.Dishes.AsNoTracking().ToArrayAsync();
Console.WriteLine($"read from Database with AsNoTracking(): {dbContext.Entry(dishesNoTracking[0]).State}\n");


//We can also use SQLqueries in Linq explicitly with FromSqlRaw() method.
var dishesRaw = await dbContext.Dishes.FromSqlRaw("select * from dishes").ToArrayAsync();


//if we want to let the user to specify something and we want to write query based on that
var filter = "%r";
var dishesRawInterpolated = dbContext.Dishes
    .FromSqlInterpolated($"SELECT * FROM dishes WHERE notes LIKE {filter}");

foreach (var dish in dishesRawInterpolated)
{
    Console.WriteLine($"ID:{dish.Id} - Title:{dish.Title} - Note:{dish.Notes}");
}


//if we want to make changes to the data base with the help of RAW method
//await dbContext.Database.ExecuteSqlRawAsync("DELETE FROM dishes WHERE Id NOT IN (SELECT dishId FROM Ingredients)");


//If we want to roll back changes if an error happens in our codes
using var transaction = await dbContext.Database.BeginTransactionAsync();
try
{
    dbContext.Dishes.Add(new Dish { Title = "Foo", Notes = "delicious" });
    await dbContext.SaveChangesAsync();
    await dbContext.Database.ExecuteSqlRawAsync("SELECT 1/0");
    await transaction.CommitAsync();
}
catch (SqlException ex)
{
    Console.Error.WriteLine($"\nSomething Bad Has happened: {ex.Message}");
}


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