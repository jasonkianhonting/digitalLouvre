using System.ComponentModel.DataAnnotations;
using System.Net;
using backend.Models.digitalLouvreDTO;

namespace backend.Models;

public record ResponseDto
{
    [Required]
    public MuseumApiDto? Data{ get; init; }
    
    public bool IsSuccess { get; init; }
    
    public string? ErrorMessage { get; init; }  
    
    public HttpStatusCode StatusCode { get; init; }
}