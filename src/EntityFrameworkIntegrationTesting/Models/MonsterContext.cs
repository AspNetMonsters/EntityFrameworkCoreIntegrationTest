using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntegrationTesting.Models
{
    public class MonsterContext : DbContext
    {
        public MonsterContext(DbContextOptions<MonsterContext> options)
            : base(options)
        {
        }

        public DbSet<Monster> Monsters { get; set; }
    }
}
