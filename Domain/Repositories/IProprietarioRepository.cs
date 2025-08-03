

using Domain.Entities;

namespace Domain.Repositories;

public interface IProprietarioRepository : IBaseRepository<Proprietario>
{
    Task<Proprietario> FindByDocument(string document);
}
