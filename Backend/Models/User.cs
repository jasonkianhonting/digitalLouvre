using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class User
{
    [Key] public Guid UserId { get; set; }
    [MaxLength(100)] public string? FirstName { get; set; }
    [MaxLength(100)] public string? LastName { get; set; }
    [Required] [MaxLength(50)] public string? Username { get; set; }

    [Required] [PasswordPropertyText] public string? Password { get; set; }

    public string Token { get; set; }
    public DateTime TokenExpiry { get; set; }
}