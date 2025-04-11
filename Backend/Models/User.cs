using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class User
{
    [Required] [Key]
    public Guid Id { get; set; }
    public string FistName { get; set; }
    public string LastName { get; set; }
    [Required][PasswordPropertyText]
    public string Password { get; set; }
    public string Token { get; set; }
    public DateTime TokenExpiry { get; set; }
}