using System.Data.Entity;

namespace VidzyCF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext():base("LocalConnection")
        {
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Video> Videos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
