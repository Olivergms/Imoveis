
namespace Domain.Dtos;

public class RequestCriarImovelDto
{
    public int Area { get; set; }
    public required string Endereco { get; set; }
    public int ProprietarioId { get; set; }
}
