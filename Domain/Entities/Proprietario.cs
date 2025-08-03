using Domain.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Proprietario
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Documento { get; set; }
    public virtual ICollection<Imovel> Imoveis { get; set; }

    public Proprietario(RequestCriarProprietarioDto dto)
    {
        Nome = dto.Nome;
        Documento = dto.Documento;
    }

    public Proprietario()
    {
    }
}
