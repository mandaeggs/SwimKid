using Microsoft.EntityFrameworkCore;

namespace SwimKids.Data
{
    public class SwimKidsContext: DbContext
    {
        public SwimKidsContext(DbContextOptions<SwimKidsContext> options) : base(options)
        {

        }

        public DbSet<Lesson> Lessons { get; set; }
    }
}
