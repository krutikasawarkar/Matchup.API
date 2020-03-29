using Microsoft.EntityFrameworkCore;

namespace MatchUp.API.MatchUp.Repository.Configurations
{
    public class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        { }
    }
}