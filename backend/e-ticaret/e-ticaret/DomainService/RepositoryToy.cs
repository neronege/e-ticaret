using e_ticaret.Models;

namespace e_ticaret.DomainService
{
    public class RepositoryToy : RepositoryBase<Toy, ApplicationDbContext>, IRepositoryToy
    {
        private readonly ApplicationDbContext context;
        public RepositoryToy(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
