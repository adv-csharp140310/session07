using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session06.Model;
public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    //Naming Convention
    public int UserId { get; set; }

    //Navigation Property
    public User Author { get; set; }
}
