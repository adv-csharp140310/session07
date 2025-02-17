using session06.Model;

namespace session06.Repositoy;
public class GenericRepository<T> where T : BaseEntity
{
    //crud

    public void Add(T model)
    {
        using var ctx = new AppDbContext();
        ctx.Add(model);
        ctx.SaveChanges();
    }

    public void Update(T model)
    {
        using var ctx = new AppDbContext();        
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    public void Delete(T model)
    {
        using var ctx = new AppDbContext();
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        ctx.SaveChanges();
    }

    public T GetById(int Id)
    {
        using var ctx = new AppDbContext();
        //return ctx.Set<T>().Find(Id);
        return ctx.Set<T>().FirstOrDefault(x => x.Id == Id);
    }

    //leaky abstraction
    public IQueryable<T> Get()
    {
        var ctx = new AppDbContext();
        return ctx.Set<T>().AsQueryable();
    }
}
