using Jobsee.Application.Contracts.Persistence.General;
//using Jobsee.Application.Contracts.Persistence.Operaciones;
using Jobsee.Domain.Common;

namespace Jobsee.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        //IPersonaRepository PersonaRepository { get; }
        //IClienteRepository ClienteRepository { get; }
        //ICuentaRepository CuentaRepository { get; }
        //IMovimientosRepository MovimientosRepository { get; }

        IConstanteRepository ConstanteRepository { get; }
        
        IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel;

        Task<int> Transaction();
        Task<int> Complete();
    }
}
