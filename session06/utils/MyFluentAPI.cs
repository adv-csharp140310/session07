using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session06.utils;
public class MyFluentAPI
{
    protected int Port { get; set; }
    protected string Username { get; set; }
    protected string Password { get; set; }


    public MyFluentAPI HasPort(int port)
    {
        Port = port;
        return this;
    }

    public MyFluentAPI HasUsername(string username)
    {
        Username = username;
        return this;
    }

    public MyFluentAPI HasPassword(string password)
    {
        Password = password;
        return this;
    }
}
