using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MPA.Phone.Authorization.Roles;
using MPA.Phone.Authorization.Users;
using MPA.Phone.MultiTenancy;

namespace MPA.Phone.EntityFrameworkCore
{
    public class PhoneDbContext : AbpZeroDbContext<Tenant, Role, User, PhoneDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PhoneDbContext(DbContextOptions<PhoneDbContext> options)
            : base(options)
        {
        }
    }
}
