using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Backend.Models;

public class User
{
    [Key] public Guid UserId { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("firstName")]
    public string? FirstName { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("lastName")]
    public string? LastName { get; set; }

    [Required]
    [MaxLength(50)]
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [Required]
    [PasswordPropertyText]
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    // public string Token { get; set; }
    // public DateTime TokenExpiry { get; set; }
}