using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABP.DY.EntityFrameworkCore
{
    public static class DYDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DYDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DYDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
