using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


var factory = new BrickContextFactory();
using var context = factory.CreateDbContext();


await QueryData();


#region AddData

//Vendor brickKing, heldDerSteine;

//await context.Vendors.AddRangeAsync(new[]
//{
//    brickKing =  new Vendor(){vendorName = "Brick king"},
//    heldDerSteine =  new Vendor(){vendorName = "held der Steine"}
//});
//await context.SaveChangesAsync();



//Tag rare, ninjago, minecraft;

//await context.Tags.AddRangeAsync(new[]
//{
//    rare =  new Tag(){Title = "Rare"},
//    ninjago =  new Tag(){Title = "Ninjago"},
//    minecraft =  new Tag(){Title = "Minecraft"},
//});
//await context.SaveChangesAsync();



//await context.Bricks.AddRangeAsync(new BasePlate
//{
//    Title = "BasePlate 16 * 16 with blue water pattern",
//    Color = color.Green,
//    Tags = {rare, minecraft},
//    Length = 16,
//    Width = 16,
//    Availability =
//    {
//        new BrickAvailability() { vendor = brickKing, AvailableAmount = 5, PriceEuro = 6.5m},
//        new BrickAvailability(){vendor = heldDerSteine, AvailableAmount = 10, PriceEuro = 5.9m },
//    }
//});
//await context.SaveChangesAsync();

#endregion


async Task QueryData()
{
    var saleItems = await context.BrickAvailabilities
        .Include(ba => ba.brick)
        .Include(ba => ba.vendor)
        .ToArrayAsync();
    foreach (var item in saleItems)
    {
        Console.WriteLine($"Brick {{{item.brick.Title}}} is saled by {{{item.vendor.vendorName}}} for ${{{item.PriceEuro}}} ");
    }
    Console.WriteLine();


    var brickWithVendorAndTags = await context.Bricks
        .Include(ba => ba.Tags)
        .ToArrayAsync();
    foreach( var item in brickWithVendorAndTags)
    {
        Console.WriteLine($"Brack {{{item.Title}}}");
        if (item.Tags.Any()) Console.WriteLine($"{string.Join(',',item.Tags.Select(t => t.Title))}");
    }
}




#region Model
//Brick - Tag have many to many relationship

public enum color
{
    Black,
    White,
    Red,
    Yellow,
    Orange,
    Green
}

public class Brick
{
    public int Id { get; set; }
    [MaxLength(250)]
    public string Title { get; set; } = string.Empty;
    public color? Color { get; set; }
    public List<Tag> Tags { get; set; } = new();
    public List<BrickAvailability> Availability { get; set; } = new();
}

public class BasePlate : Brick
{
    public int Width { get; set; }
    public int Length { get; set; }
}

public class MinifigHead : Brick
{
    public bool IsDualSided { get; set; }
}

public class Tag
{
    public int Id { get; set; }
    [MaxLength(250)]
    public string Title { get; set; } = string.Empty;
    public List<Brick> Bricks { get; set; } = new();
}


public class Vendor
{
    public int Id { get; set; }
    [MaxLength(250)]
    public string vendorName { get; set; }
    public List<BrickAvailability> Availability { get; set; } = new();
}


public class BrickAvailability
{
    public int Id { get; set; }
    public Vendor vendor { get; set; }
    public int VendorId { get; set; }
    public Brick brick { get; set; }
    public int BrickId { get; set; }
    public int AvailableAmount { get; set; }
    [Column(TypeName ="decimal(8, 2)")]
    public Decimal PriceEuro { get; set; }
}

#endregion


#region Data Context
public class BrickContext : DbContext
{
    public BrickContext(DbContextOptions<BrickContext> options)
        : base(options)
    { }

    public DbSet<Brick> Bricks { get; set; }
    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<BrickAvailability> BrickAvailabilities { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BasePlate>().HasBaseType<Brick>();
        modelBuilder.Entity<MinifigHead>().HasBaseType<Brick>();
    }
}

class BrickContextFactory : IDesignTimeDbContextFactory<BrickContext>
{
    public BrickContext CreateDbContext(string[] args = null)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("AppSettings.json").Build();

        var optionsBuilder = new DbContextOptionsBuilder<BrickContext>();
        optionsBuilder
            // Uncomment the following line if you want to print generated
            // SQL statements on the console.
            // .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            .UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

        return new BrickContext(optionsBuilder.Options);
    }
}

#endregion