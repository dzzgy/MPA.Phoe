using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MPA.Phone.EntityFrameworkCore
{
    public static class PhoneDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PhoneDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);//֧��2012���ϵ�

            //������֧��2005 ��2008��
            builder.UseSqlServer(connectionString, b => b.UseRowNumberForPaging());
        }

        public static void Configure(DbContextOptionsBuilder<PhoneDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            //ͬ��
            builder.UseSqlServer(connection, b => b.UseRowNumberForPaging());
        }
    }
}
