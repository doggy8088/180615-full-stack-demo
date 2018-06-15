using Microsoft.EntityFrameworkCore;

namespace demo1.Models {
    public class KSContext : DbContext {
        public KSContext (DbContextOptions<KSContext> options) : base (options) { }
        
        public DbSet<Record> ScenicSpots { get; set; }
    }
}