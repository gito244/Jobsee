using AutoMapper;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Features.General.Constantes.Queries.Vms;
using Jobsee.Application.Features.Operaciones.Clientes.Queries.GetAllClientesList;
using Jobsee.Application.Features.Operaciones.Clientes.Queries.Vms;
using Jobsee.Domain.General;
using Jobsee.Domain.Operaciones;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Jobsee.Application.Features.General.Constantes.Queries.GetAllConstantesList
{
    public class GetAllConstantesListQueryHandler : IRequestHandler<GetAllConstantesListQuery, List<ConstantesWithinIncludesVmResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly ILogger _logger;

        public GetAllConstantesListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)//, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            //_logger = logger;
        }
        //public async Task<List<ConstanteWithinIncludeVmResponse>> Handle(GetAllClientesListQuery request, CancellationToken cancellationToken)
        //{
        //    var includes = new List<Expression<Func<Cliente, object>>>();
        //    includes.Add(p => p.Persona!);

        //    var clienteList = await _unitOfWork.Repository<Cliente>().GetAsync(
        //        b => b.ClienteId >= 0,
        //        b => b.OrderBy(x => x.ClienteId),
        //        includes,
        //        true);

        //    return _mapper.Map<List<ConstanteWithinIncludeVmResponse>>(clienteList);
        //}

        async Task<List<ConstantesWithinIncludesVmResponse>> IRequestHandler<GetAllConstantesListQuery, List<ConstantesWithinIncludesVmResponse>>.Handle(GetAllConstantesListQuery request, CancellationToken cancellationToken)
        {
            var constanteList = await _unitOfWork.ConstanteRepository.GetAllAsync();
            //var constanteList2 = await _unitOfWork.Repository<Constante>().GetAllAsync();

            return _mapper.Map<List<ConstantesWithinIncludesVmResponse>>(constanteList);
        }
    }
}
