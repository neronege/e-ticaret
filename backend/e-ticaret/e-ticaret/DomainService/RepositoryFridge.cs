using e_ticaret.Models;

namespace e_ticaret.DomainService
{
    public class RepositoryFridge : RepositoryBase<Fridge, ApplicationDbContext>, IRepositoryFridge
    {
        private readonly ApplicationDbContext context;
   
        public RepositoryFridge(ApplicationDbContext context) : base(context)
        {
         this.context = context;
        }
    }
}
