using session06.Model;

namespace session06.Repositoy;
public class UserRepository
{
    //crud

    public void Add(User model)
    {
        var ctx = new AppDbContext();
        ctx.Add(model);
        ctx.SaveChanges();
    }
}
