using session06.Model;
using session06.Repositoy;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt;

namespace session06.Service;
public  class UserService
{
    //UserRepository userRepository;
    //GenericRepository<User> repository;
    GenericRepositoryNew repository;

    public UserService()
    {
        //SOLID - Dependcy Injection
        //userRepository = new UserRepository();
        //repository = new GenericRepository<User>();
        repository = new GenericRepositoryNew();
    }

    public void Add(User model)
    {
        //Validation
        if (string.IsNullOrWhiteSpace(model.Password) || model.Password.Length < 6)
        {
           //throw new ArgumentException("");
        }

        //Business Logic

        //Database
        model.Password = BCrypt.Net.BCrypt.HashPassword(model.Password);

        repository.Add(model);                
        //var b = new Blog();
        //repository.Add(b);

    }

    //1- List<User>
    //2- Iqueryable<User>
    public (List<User>, int) LoadData(bool? isActive, string namTerm, int page, int pageSize)
    {
        var query = repository.Get<User>();
        if (isActive.HasValue)
        {
            query = query.Where(x => x.IsActive == isActive);
        }
        if (!string.IsNullOrWhiteSpace(namTerm))
        {
            query = query
                .Where(x => x.FirstName.Contains(namTerm) || x.LastName.Contains(namTerm));
        }

        var result = query
            .Skip(pageSize * page)
            .Take(pageSize).ToList();

        var total = query.Count();

        return (result, total);
    }
}
