using AspNetCoreSQLite.Model;
using Microsoft.EntityFrameworkCore;

namespace AspNet5SQLite.Model
{
    // >dotnet ef migration add testMigration
    public class KingsAwardDataBase : DbContext
    {
        public KingsAwardDataBase(DbContextOptions<KingsAwardDataBase> options) :base(options)
        { }
        
        public DbSet<Child> Children { get; set; }
        public DbSet<Archive> Archives { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<TaskDone> TasksDone { get; set; }
        public DbSet<Activity> Activites { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        { 
            builder.Entity<Child>().HasKey(m => m.id);
            builder.Entity<Archive>().HasKey(m => m.id);
            builder.Entity<Task>().HasKey(m => m.id);
            builder.Entity<TaskDone>().HasKey(m => m.id);
            builder.Entity<Award>().HasKey(m => m.id);
            builder.Entity<Activity>().HasKey(m => m.id);
            base.OnModelCreating(builder);

        } 
    }
}