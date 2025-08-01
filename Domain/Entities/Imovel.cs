
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Imovel
{
    [Key]
    public int Id { get; set; }
    public int Area { get; set; }
    public required string Endereco { get; set; }
    public int Id_Proprietario { get; set; }
    public virtual int Valor { get; set; }
}
