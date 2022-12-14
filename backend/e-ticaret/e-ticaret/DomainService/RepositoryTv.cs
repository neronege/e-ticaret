using e_ticaret.Models;

namespace e_ticaret.DomainService
{
    public class RepositoryTv : RepositoryBase<Tv, ApplicationDbContext>, IRepositoryTv
    {
        private readonly ApplicationDbContext context;
        public RepositoryTv(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
