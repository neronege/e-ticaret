using e_ticaret.Models;

namespace e_ticaret.DomainService
{
    public class RepositoryPhone : RepositoryBase<Phone, ApplicationDbContext>, IRepositoryPhone
    {
        private readonly ApplicationDbContext context;
        public RepositoryPhone(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
