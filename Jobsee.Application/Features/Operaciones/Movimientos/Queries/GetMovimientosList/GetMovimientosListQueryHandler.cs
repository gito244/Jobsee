﻿using AutoMapper;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Features.Operaciones.Movimientos.Queries.Vms;
using MediatR;

namespace Jobsee.Application.Features.Operaciones.Movimientos.Queries.GetMovimientosList
{
    public class GetMovimientosListQueryHandler : IRequestHandler<GetMovimientosListQuery, List<MovimientosWithIncludesVmResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetMovimientosListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<MovimientosWithIncludesVmResponse>> Handle(GetMovimientosListQuery request, CancellationToken cancellationToken)
        {
            //var movimientosList = await _unitOfWork.MovimientosRepository.GetMovimientosFechasxUsuario(request.FechaInicio, request.FechaFin, request.Cliente);
            //return _mapper.Map<List<MovimientosWithIncludesVmResponse>>(movimientosList);
            return new List<MovimientosWithIncludesVmResponse>();
        }
    }
}
