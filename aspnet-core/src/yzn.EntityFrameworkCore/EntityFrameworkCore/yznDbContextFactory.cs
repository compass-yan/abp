using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using yzn.Configuration;
using yzn.Web;

namespace yzn.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class yznDbContextFactory : IDesignTimeDbContextFactory<yznDbContext>
    {
        public yznDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<yznDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            yznDbContextConfigurer.Configure(builder, configuration.GetConnectionString(yznConsts.ConnectionStringName));

            return new yznDbContext(builder.Options);
        }
    }
}
