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
    UserRepository userRepository;

    public UserService()
    {
        //SOLID - Dependcy Injection
        UserRepository userRepository = new UserRepository();
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
        userRepository.Add(model);
    }
}
