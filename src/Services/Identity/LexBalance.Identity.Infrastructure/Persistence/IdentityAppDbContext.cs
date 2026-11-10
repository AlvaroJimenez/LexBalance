using LexBalance.Identity.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LexBalance.Identity.Infrastructure.Persistence;

public class IdentityAppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
{
    public IdentityAppDbContext(DbContextOptions<IdentityAppDbContext> options) : base(options) { }

    // TODO: configuracion del modelo (OnModelCreating)
}
