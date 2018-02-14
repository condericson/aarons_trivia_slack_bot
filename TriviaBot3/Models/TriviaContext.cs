using Microsoft.EntityFrameworkCore;

namespace TriviaBot3.Models
{
    public class TriviaContext : DbContext
    {
        public TriviaContext(DbContextOptions options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.Question)
                .WithMany(q => q.Answers);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)
                .WithOne(a => a.Question);

            modelBuilder.Entity<Player>();
        }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Attempt> Attempts { get; set; }
    }
}
