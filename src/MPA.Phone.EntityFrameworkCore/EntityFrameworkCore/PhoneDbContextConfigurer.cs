using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MPA.Phone.EntityFrameworkCore
{
    public static class PhoneDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoneDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);//支持2012以上的

            //以下是支持2005 与2008的
            builder.UseSqlServer(connectionString, b => b.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<PhoneDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            //同上
            builder.UseSqlServer(connection, b => b.UseRowNumberForPaging());
        }
    }
}
