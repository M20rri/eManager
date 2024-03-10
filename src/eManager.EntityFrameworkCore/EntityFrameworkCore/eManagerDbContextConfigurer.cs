using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace eManager.EntityFrameworkCore
{
    public static class eManagerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<eManagerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<eManagerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
