using Jobsee.Application.Contracts.Infrastructure;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Contracts.Persistence.General;
//using Jobsee.Application.Contracts.Persistence.Operaciones;
using Jobsee.Application.Models;
using Jobsee.Infrastructure.Email;
using Jobsee.Infrastructure.Persistence;
using Jobsee.Infrastructure.Repositories;
using Jobsee.Infrastructure.Repositories.General;
using Jobsee.Infrastructure.Repositories.Operaciones;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jobsee.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JobseeDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))
            );

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

            //services.AddScoped<IPersonaRepository, PersonaRepository>();
            //services.AddScoped<IClienteRepository, ClienteRepository>();
            //services.AddScoped<ICuentaRepository, CuentaRepository>();
            //services.AddScoped<IMovimientosRepository, MovimientosRepository>();

            services.AddScoped<IConstanteRepository, ConstanteRepository>();

            services.Configure<EmailSettings>(c => configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }

    }
}
