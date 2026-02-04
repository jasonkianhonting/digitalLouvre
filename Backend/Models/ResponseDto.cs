using System.ComponentModel.DataAnnotations;
using backend.Models.digitalLouvreDTO;

namespace backend.Models;

public record ResponseDto
{
    [Required] public MuseumApiDto? Data { get; init; }

    public bool IsSuccess { get; init; }
}