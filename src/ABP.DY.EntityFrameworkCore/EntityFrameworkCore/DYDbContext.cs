using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABP.DY.Authorization.Roles;
using ABP.DY.Authorization.Users;
using ABP.DY.MultiTenancy;

namespace ABP.DY.EntityFrameworkCore
{
    public class DYDbContext : AbpZeroDbContext<Tenant, Role, User, DYDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DYDbContext(DbContextOptions<DYDbContext> options)
            : base(options)
        {
        }
    }
}
