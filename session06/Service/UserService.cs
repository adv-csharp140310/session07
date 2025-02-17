using session06.Model;
using session06.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session06.Service;
public  class UserService
{
    //UserRepository userRepository;
    GenericRepository<User> repository;

    public UserService()
    {
        //SOLID - Dependcy Injection
        //userRepository = new UserRepository();
        repository = new GenericRepository<User>();
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
        repository.Add(model);

        //Unit of work
        //var b = new Blog();
        //repository.Add(b);
    }
}
