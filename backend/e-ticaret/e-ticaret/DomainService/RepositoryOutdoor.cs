using e_ticaret.Models;

namespace e_ticaret.DomainService
{
    public class RepositoryOutdoor : RepositoryBase<Outdoor, ApplicationDbContext>,IRepositoryOutdoor
    {
        private readonly ApplicationDbContext context;
        public RepositoryOutdoor(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
