using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MPA.Phone.Configuration;
using MPA.Phone.Web;

namespace MPA.Phone.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PhoneDbContextFactory : IDesignTimeDbContextFactory<PhoneDbContext>
    {
        public PhoneDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PhoneDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PhoneConsts.ConnectionStringName));

            return new PhoneDbContext(builder.Options);
        }
    }
}
