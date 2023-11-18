using Blau.Data;
using Blau.Flex.Core.TenantAggregate;
using Blau.Services;

using Microsoft.EntityFrameworkCore;

using System.Linq.Expressions;

namespace Blau.Flex.Data;

public class ApplicationDatabaseContext(
    DbContextOptions<ApplicationDatabaseContext> options,
    ITenantService tenantService) : IdentityDataContext<ApplicationDatabaseContext>(options)
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        Expression<Func<Tenant, bool>> exp = t => t.Id == tenantService.GetTenantId();
        modelBuilder.Entity<Tenant>().HasQueryFilter(exp);
    }

    public DbSet<Tenant> Tenants => Set<Tenant>();
}
