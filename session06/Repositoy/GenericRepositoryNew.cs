﻿using session06.Model;

namespace session06.Repositoy;
public class GenericRepositoryNew
{
    //crud
    AppDbContext ctx = new AppDbContext();

    public void Add<T>(T model) where T : BaseEntity
    {
        ctx.Add(model);
        ctx.SaveChanges();
    }

    public void Update<T>(T model) where T : BaseEntity
    {
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    public void Delete<T>(T model) where T : BaseEntity
    {
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        ctx.SaveChanges();
    }

    public T GetById<T>(int Id) where T : BaseEntity
    {
        return ctx.Set<T>().FirstOrDefault(x => x.Id == Id);
    }

    //leaky abstraction
    public IQueryable<T> Get<T>() where T : BaseEntity
    {
        var ctx = new AppDbContext();
        return ctx.Set<T>().AsQueryable();
    }
}
