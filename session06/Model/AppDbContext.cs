using Microsoft.EntityFrameworkCore;
using session06.Model.Config;
using session06.utils;
using System.Diagnostics;
using System.Reflection;

namespace session06.Model;
public class AppDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("data source=.;initial catalog=cs140310_ef;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EFCodeFirst");
        optionsBuilder.LogTo(msg => Debug.WriteLine(msg));
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfiguration(new UserConfig());
        //modelBuilder.ApplyConfiguration(new ProductConfig());

        //Refleaction //<-

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        

        //******

        var api = new MyFluentAPI();
        api.HasPort(100);
        api.HasUsername("xyz");
        api.HasPassword("abc");

        var api2 = new MyFluentAPI();
        api2.HasPort(100)
            .HasUsername("xyz")
            .HasPassword("abc")
        ;

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users {  get; set; }
    public DbSet<Product> Products {  get; set; }

}
