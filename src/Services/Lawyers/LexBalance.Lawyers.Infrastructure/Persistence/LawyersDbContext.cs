using Microsoft.EntityFrameworkCore;

namespace LexBalance.Lawyers.Infrastructure.Persistence;

public class LawyersDbContext : DbContext
{
    public LawyersDbContext(DbContextOptions<LawyersDbContext> options) : base(options) { }

    // TODO: DbSet<Lawyer>, DbSet<AssignedCase>
}
