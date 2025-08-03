using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories;

public class ProprietarioRepository : IProprietarioRepository
{
    private readonly ApplicationDbContext _db;

    public ProprietarioRepository(ApplicationDbContext context) => _db = context;


    public async Task DeleteAsync(Proprietario entity)
    {
        
        _db.Proprietarios.Remove(entity);

        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<Proprietario>> FindallAsync()
    {
        return _db.Proprietarios.AsNoTracking().ToList();
    }

    public async Task<Proprietario> FindByIdAsync(int id)
    {
        return await _db.Proprietarios.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task InsertAsync(Proprietario entity)
    {
        await _db.AddAsync(entity);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(Proprietario entity)
    {
        var proprietario = await _db.Proprietarios.FindAsync(entity.Id);
        if (proprietario == null) throw new Exception("Rota não encontrada");

        _db.Entry(proprietario).CurrentValues.SetValues(entity);
        await _db.SaveChangesAsync();
    }
}
