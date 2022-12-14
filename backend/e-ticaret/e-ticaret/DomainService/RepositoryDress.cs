using e_ticaret.Models;

namespace e_ticaret.DomainService
{
    public class RepositoryDress : RepositoryBase<Dress, ApplicationDbContext>, IRepositoryDress
    {
        private readonly ApplicationDbContext context;
        public RepositoryDress(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
