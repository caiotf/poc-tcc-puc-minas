using Microsoft.EntityFrameworkCore;

namespace GSL.ProductAPI.Model.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext()
        {
        }
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
