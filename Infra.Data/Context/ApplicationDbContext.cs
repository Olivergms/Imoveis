
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }
}
