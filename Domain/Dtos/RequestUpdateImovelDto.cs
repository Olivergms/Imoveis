
namespace Domain.Dtos;

public class RequestUpdateImovelDto
{
    public int Id { get; set; }
    public int Area { get; set; }
    public required string Endereco { get; set; }
    public int ProprietarioId { get; set; }
}
