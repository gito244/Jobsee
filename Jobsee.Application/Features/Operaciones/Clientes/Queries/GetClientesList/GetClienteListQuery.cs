using Jobsee.Application.Features.Operaciones.Clientes.Queries.Vms;
using MediatR;

namespace Jobsee.Application.Features.Operaciones.Clientes.Queries.GetClientesList
{
    public class GetClienteListQuery : IRequest<List<ClienteWithIncludeVmResponse>>
    {
        public GetClienteListQuery(int cliente)
        {
            Cliente = cliente;
        }

        public int Cliente { get; set; }
    }
}
