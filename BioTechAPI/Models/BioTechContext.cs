using Microsoft.EntityFrameworkCore;

namespace BioTechAPI.Models
{
    public class BioTechContext : DbContext
    {
        public BioTechContext(DbContextOptions<BioTechContext> options) : base(options) { }

        public DbSet<Position> Positions { get; set; }
    }
}
