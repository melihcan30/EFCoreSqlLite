using Microsoft.EntityFrameworkCore;

namespace EFCoreSqlLite.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<RpgCharacter> RpgCharacter => Set<RpgCharacter>();
    }
}
