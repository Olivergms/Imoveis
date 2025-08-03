
using Domain.Dtos;
using Domain.Entities;

namespace Domain.Services;

public interface IProprietarioService
{
    Task Insertsync(RequestCriarProprietarioDto dto);
    Task<IEnumerable<Proprietario>> FindAllAsync();
    Task<Proprietario> FindByDocumentAsync(string documento);
    Task DeleteAsync(int id);
    Task UpdateAsync(Proprietario proprietario, int id);
}
