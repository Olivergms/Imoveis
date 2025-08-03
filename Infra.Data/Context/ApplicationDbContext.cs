
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Proprietario> Proprietarios { get; set; }
    public DbSet<Imovel> Imoveis { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }

}
