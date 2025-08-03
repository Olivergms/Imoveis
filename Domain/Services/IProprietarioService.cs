
using Domain.Dtos;
using Domain.Entities;

namespace Domain.Services;

public interface IProprietarioService
{
    Task Insertsync(RequestCriarProprietarioDto dto);
    Task<IEnumerable<Proprietario>> FindAllAsync();
    Task<Proprietario> FindByIdsync(int id);
    Task DeleteAsync(int id);
    Task UpdateAsync(Proprietario proprietario, int id);
}
