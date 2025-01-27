using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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
        modelBuilder.Entity<User>().ToTable("users_xyz", "auth");
        //Fluent API
        modelBuilder.Entity<User>()
                .Property(x => x.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email_xyz")
                ;

        //******

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<User> Users {  get; set; }
    public DbSet<Product> Products {  get; set; }

}
