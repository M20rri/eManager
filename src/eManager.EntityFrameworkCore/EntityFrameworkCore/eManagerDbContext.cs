using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using eManager.Authorization.Roles;
using eManager.Authorization.Users;
using eManager.MultiTenancy;

namespace eManager.EntityFrameworkCore
{
    public class eManagerDbContext : AbpZeroDbContext<Tenant, Role, User, eManagerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public eManagerDbContext(DbContextOptions<eManagerDbContext> options)
            : base(options)
        {
        }
    }
}
