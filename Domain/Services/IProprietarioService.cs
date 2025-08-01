
using Domain.Dtos;

namespace Domain.Services;

public interface IProprietarioService
{
    Task Insert(RequestCriarProprietarioDto dto);
}
