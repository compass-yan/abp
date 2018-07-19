using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace yzn.EntityFrameworkCore
{
    public static class yznDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<yznDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<yznDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
