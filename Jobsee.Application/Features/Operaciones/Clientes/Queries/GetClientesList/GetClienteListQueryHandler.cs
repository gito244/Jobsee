using AutoMapper;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Features.Operaciones.Clientes.Queries.Vms;
using Jobsee.Domain.Operaciones;
using MediatR;
using System.Linq.Expressions;

namespace Jobsee.Application.Features.Operaciones.Clientes.Queries.GetClientesList
{
    //public class GetClienteListQueryHandler : IRequestHandler<GetClienteListQuery, List<ClienteWithIncludeVmResponse>>
    //{
    //    private readonly IUnitOfWork _unitOfWork;
    //    private readonly IMapper _mapper;

    //    public GetClienteListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    //    {
    //        _unitOfWork = unitOfWork;
    //        _mapper = mapper;
    //    }

    //    public async Task<List<ClienteWithIncludeVmResponse>> Handle(GetClienteListQuery request, CancellationToken cancellationToken)
    //    {
    //        var includes = new List<Expression<Func<Cliente, object>>>();
    //        includes.Add(p => p.Persona!);

    //        var clienteList = await _unitOfWork.Repository<Cliente>().GetAsync(
    //            b => b.ClienteId == request.Cliente,
    //            b => b.OrderBy(x => x.ClienteId),
    //            includes,
    //            true
    //            );

    //        return _mapper.Map<List<ClienteWithIncludeVmResponse>>(clienteList);
    //    }
    //}
}
