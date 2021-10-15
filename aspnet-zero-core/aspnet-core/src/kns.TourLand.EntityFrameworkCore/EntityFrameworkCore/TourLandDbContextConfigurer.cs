using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace kns.TourLand.EntityFrameworkCore
{
    public static class TourLandDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TourLandDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TourLandDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}