
namespace Domain.Dtos;

public class RequestCriarImovelDto
{
    public int? Area { get; set; } = null;
    public string? Endereco { get; set; } = null;
    public int ProprietarioId { get; set; }
}
