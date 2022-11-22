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
       public DbSet<Product> Products {get; set;}
    }
}
