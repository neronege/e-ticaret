using e_ticaret.model;
using Microsoft.EntityFrameworkCore;

namespace e_ticaret.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
       public DbSet<Toy> Toys { get; set; }
       public DbSet<Outdoor> Outdoors { get; set; }
       public DbSet <Electronic> Electronic { get; set; }
       public DbSet<Dress> Dresses { get; set; }
       public DbSet<Fridge> Fridges { get; set; }
       public DbSet<Computer> Computers { get; set; }
       public DbSet<Tv> Tvs { get; set; }
       public DbSet<Phone> Phones { get; set; }

    }
}
