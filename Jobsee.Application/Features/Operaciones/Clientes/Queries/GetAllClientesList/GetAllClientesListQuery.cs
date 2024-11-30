using Jobsee.Application.Features.Operaciones.Clientes.Queries.Vms;
using MediatR;

namespace Jobsee.Application.Features.Operaciones.Clientes.Queries.GetAllClientesList
{
    public class GetAllClientesListQuery : IRequest<List<ClienteWithIncludeVmResponse>>
    {

    }
}
