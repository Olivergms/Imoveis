
using Domain.Dtos;
using Domain.Entities;

namespace Domain.Services;

public interface IImovelService
{
    Task InsertAsync(RequestCriarImovelDto dto);
    Task<IEnumerable<Imovel>> FindAllAsync();
    Task<Imovel> FindByIdAsync(int id);
    Task DeleteAsync(int id);
    Task UpdateAsync(RequestUpdateImovelDto ImovelDto, int id);
    Task Finish(int id);
}
