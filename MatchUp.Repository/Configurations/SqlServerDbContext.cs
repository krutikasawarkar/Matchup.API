using Microsoft.EntityFrameworkCore;

namespace MatchUp.Repository.Configurations
{
    public class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        { }
    }
}