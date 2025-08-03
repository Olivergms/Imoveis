

using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories;

public class ImovelRepository : IImovelRepository
{
    private readonly ApplicationDbContext _db;

    public ImovelRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task DeleteAsync(Imovel entity)
    {
        _db.Imoveis.Remove(entity);

        await _db.SaveChangesAsync();
    }

    public async Task<IEnumerable<Imovel>> FindallAsync()
    {
        return await _db.Imoveis.AsNoTracking().OrderBy(x => x.Concluido).ToListAsync() ;
    }

    public async Task<Imovel> FindByIdAsync(int id)
    {
        return await _db.Imoveis
            .Include(x => x.Proprietario)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task InsertAsync(Imovel entity)
    {
        await _db.Imoveis.AddAsync(entity);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(Imovel entity)
    {
        var imovel = await _db.Imoveis.FindAsync(entity.Id);
        if (imovel == null) throw new Exception("Rota não encontrada");

        _db.Entry(imovel).CurrentValues.SetValues(entity);
        await _db.SaveChangesAsync();
    }
}
