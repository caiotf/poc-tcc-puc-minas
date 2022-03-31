using Microsoft.EntityFrameworkCore;

namespace GSL.RatingAPI.Model.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext() { }
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) { }

        public DbSet<Rating> Ratings { get; set; }
    }
}
