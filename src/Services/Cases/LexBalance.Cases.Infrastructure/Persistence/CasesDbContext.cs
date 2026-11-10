using Microsoft.EntityFrameworkCore;

namespace LexBalance.Cases.Infrastructure.Persistence;

public class CasesDbContext : DbContext
{
    public CasesDbContext(DbContextOptions<CasesDbContext> options) : base(options) { }

    // TODO: DbSet<Case>
}
