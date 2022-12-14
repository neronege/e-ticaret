using e_ticaret.Models;

namespace e_ticaret.DomainService
{
    public class RepositoryComputer : RepositoryBase<Computer, ApplicationDbContext>, IRepositoryComputer
    {
        private readonly ApplicationDbContext context;
        public RepositoryComputer(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }

   
       
}
