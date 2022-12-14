using e_ticaret.Models;

namespace e_ticaret.DomainService
{
    public class RepositoryElectronic : RepositoryBase<Electronic, ApplicationDbContext>, IRepositoryElectronic
    {
        private readonly ApplicationDbContext context;
        public RepositoryElectronic(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
