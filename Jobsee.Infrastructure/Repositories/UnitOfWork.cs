using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Contracts.Persistence.General;
//using Jobsee.Application.Contracts.Persistence.Operaciones;
using Jobsee.Domain.Common;
using Jobsee.Infrastructure.Persistence;
using Jobsee.Infrastructure.Repositories.General;
//using Jobsee.Infrastructure.Repositories.Operaciones;
//using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Collections;

namespace Jobsee.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private Hashtable _repositories;
        private readonly JobseeDbContext _context;

        //private IPersonaRepository _personaRepository;
        //private IClienteRepository _clienteRepository;
        //private ICuentaRepository _cuentaRepository;
        //private IMovimientosRepository _movimientosRepository;

        private IConstanteRepository _constanteRepository;

        //public IPersonaRepository PersonaRepository => _personaRepository ??= new PersonaRepository(_context);
        //public IClienteRepository ClienteRepository => _clienteRepository ??= new ClienteRepository(_context);
        //public ICuentaRepository CuentaRepository => _cuentaRepository ??= new CuentaRepository(_context);
        //public IMovimientosRepository MovimientosRepository => _movimientosRepository ??= new MovimientosRepository(_context);

        public IConstanteRepository ConstanteRepository => _constanteRepository ??= new ConstanteRepository(_context);

        public UnitOfWork(JobseeDbContext context)
        {
            _context = context;
        }

        public JobseeDbContext JobseeDbContext => _context;

        public async Task<int> Transaction()
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return 1;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception($"{ex.Message}");
                }
            }
        }

        public async Task<int> Complete()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex) {
                throw new Exception("Err");
            }
            
        }

        public void Dispose()
        {
           _context.Dispose();
        }

        public IAsyncRepository<TEntity> Repository<TEntity>() where TEntity : BaseDomainModel
        {
            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositoryBase<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
                _repositories.Add(type, repositoryInstance);
            }

            return (IAsyncRepository<TEntity>)_repositories[type];
        }


    }
}
