using Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Persistence
{
    public class ApplicaitonDbContext : DbContext
    {
        public ApplicaitonDbContext(DbContextOptions<ApplicaitonDbContext> options) : base(options)
        {

                
        }
        public DbSet<Car> Cars { get; set; }
    }
}
