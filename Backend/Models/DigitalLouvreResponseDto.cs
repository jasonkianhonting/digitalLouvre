namespace Backend.Models;

public class DigitalLouvreResponseDto
{
    public bool? IsSuccess { get; set; }
    public string? Message { get; set; }
    public string? Exception { get; set; }
}