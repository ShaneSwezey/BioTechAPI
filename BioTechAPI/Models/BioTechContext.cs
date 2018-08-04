using Microsoft.EntityFrameworkCore;

namespace BioTechAPI.Models
{
    public class BioTechContext : DbContext
    {
        public BioTechContext(DbContextOptions<BioTechContext> options) : base(options) { }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Responsibility> Responsibilities { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
        
    }
}
