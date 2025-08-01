

using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;

namespace Infra.Data.Repositories;

public class ProprietarioRepository : IProprietarioRepository
{
    private readonly ApplicationDbContext _db;

    public ProprietarioRepository(ApplicationDbContext context) => _db = context;


    public Task DeleteAsync(Proprietario entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Proprietario>> FindallAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Proprietario> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task InsertAsync(Proprietario entity)
    {
        await _db.AddAsync(entity);
        await _db.SaveChangesAsync();
    }

    public Task UpdateAsync(Proprietario entity)
    {
        throw new NotImplementedException();
    }
}
