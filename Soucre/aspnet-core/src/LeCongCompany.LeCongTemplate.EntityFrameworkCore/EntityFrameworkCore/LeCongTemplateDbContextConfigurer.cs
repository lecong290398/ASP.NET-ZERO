using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LeCongCompany.LeCongTemplate.EntityFrameworkCore
{
    public static class LeCongTemplateDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LeCongTemplateDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LeCongTemplateDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}