using session06.Model;
namespace session06.Repositoy;

public class ProductRepository
{
    //crud

    public void Add(Product model)
    {
        using var ctx = new AppDbContext();
        ctx.Add(model);
        ctx.SaveChanges();
    }

    public void Update(Product model)
    {
        using var ctx = new AppDbContext();        
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    public void Delete(Product model)
    {
        using var ctx = new AppDbContext();
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        ctx.SaveChanges();
    }

    public Product GetById(int Id)
    {
        using var ctx = new AppDbContext();
        return ctx.Products.FirstOrDefault(x => x.Id == Id);        
    }

    //leaky abstraction
    public IQueryable<Product> Get()
    {
        var ctx = new AppDbContext();
        return ctx.Products.AsQueryable();
    }
}
