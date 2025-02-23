﻿using session06.Model;

namespace session06.Repositoy;
public class UserRepository
{
    //crud

    public void Add(User model)
    {
        using var ctx = new AppDbContext();
        ctx.Add(model);
        ctx.SaveChanges();
    }

    public void Update(User model)
    {
        using var ctx = new AppDbContext();        
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        ctx.SaveChanges();
    }

    public void Delete(User model)
    {
        using var ctx = new AppDbContext();
        ctx.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        ctx.SaveChanges();
    }

    public User GetById(int Id)
    {
        using var ctx = new AppDbContext();
        return ctx.Users.FirstOrDefault(x => x.Id == Id);        
    }

    //leaky abstraction
    public IQueryable<User> Get()
    {
        var ctx = new AppDbContext();
        return ctx.Users.AsQueryable();
    }
}
