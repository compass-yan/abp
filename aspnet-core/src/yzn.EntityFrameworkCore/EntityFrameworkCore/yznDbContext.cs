using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using yzn.Authorization.Roles;
using yzn.Authorization.Users;
using yzn.MultiTenancy;

namespace yzn.EntityFrameworkCore
{
    public class yznDbContext : AbpZeroDbContext<Tenant, Role, User, yznDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public yznDbContext(DbContextOptions<yznDbContext> options)
            : base(options)
        {
        }
    }
}
