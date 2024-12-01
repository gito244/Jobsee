using Jobsee.Application.Contracts.Persistence.General;
using Jobsee.Domain.General;
using Jobsee.Infrastructure.Persistence;

namespace Jobsee.Infrastructure.Repositories.General
{
    public class ConstanteRepository : RepositoryBase<Constante>, IConstanteRepository
    {
        public ConstanteRepository(JobseeDbContext context) : base(context)
        {
            
        }
    }
}
