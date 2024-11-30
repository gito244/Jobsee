using Jobsee.Application.Features.Operaciones.Cuentas.Queries.Vms;
using MediatR;

namespace Jobsee.Application.Features.Operaciones.Cuentas.Queries.GetAllCuentasList
{
    public class GetAllCuentasListQuery : IRequest<List<CuentaWithIncludeVmResponse>>
    {
    }
}
