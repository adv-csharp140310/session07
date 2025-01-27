using System.ComponentModel.DataAnnotations;

namespace session06.Model;

//POCO - Plain Old CLR Object
//Entity

//Data Annotation (attributes)
//Fluent API
public class User
{
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public bool IsActive { get; set; }
}
