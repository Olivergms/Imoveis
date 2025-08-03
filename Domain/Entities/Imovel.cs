
using Domain.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Imovel
{
    [Key]
    public int Id { get; set; }
    public int? Area { get; set; } = 0;
    public string? Endereco { get; set; } = null;
    public bool? Concluido { get; set; } = false;
    public int ProprietarioId { get; set; }
    public virtual Proprietario? Proprietario { get; set; }
    public virtual int Valor { 
        get 
        {
            int valorTotal = 0;
            if (Area.HasValue)
            {
                if (Area > 50) valorTotal = Area.Value * 23000;
                else if (Area > 10 && Area <= 50) valorTotal = Area.Value * 24000;
                else valorTotal = Area.Value * 26000;
            }


            return valorTotal;
        } 
    }

    public void AtualizaValores(RequestUpdateImovelDto dto)
    {
        Area = dto.Area;
        Endereco = dto.Endereco;
        ProprietarioId = dto.ProprietarioId;
    }
}
