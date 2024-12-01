﻿using AutoMapper;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Features.Operaciones.Clientes.Queries.Vms;
using Jobsee.Application.Features.Operaciones.Cuentas.Queries.Vms;
using Jobsee.Domain.Operaciones;
using MediatR;
using System.Linq.Expressions;

namespace Jobsee.Application.Features.Operaciones.Cuentas.Queries.GetCuentasList
{
    //public class GetCuentaListQueryHandler : IRequestHandler<GetCuentaListQuery, List<CuentaWithIncludeVmResponse>>
    //{
    //    private readonly IUnitOfWork _unitOfWork;
    //    private readonly IMapper _mapper;

    //    public GetCuentaListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    //    {
    //        _unitOfWork = unitOfWork;
    //        _mapper = mapper;
    //    }
    //    public async Task<List<CuentaWithIncludeVmResponse>> Handle(GetCuentaListQuery request, CancellationToken cancellationToken)
    //    {
    //        var includes = new List<Expression<Func<Cuenta, object>>>();
    //        includes.Add(p => p.Cliente!);
    //        includes.Add(p => p.Cliente.Persona!);

    //        var cuentaList = await _unitOfWork.Repository<Cuenta>().GetAsync(
    //            b => b.NumeroCuenta == request.Cuenta,
    //            b => b.OrderBy(x => x.NumeroCuenta),
    //            includes,
    //            true
    //            );

    //        return _mapper.Map<List<CuentaWithIncludeVmResponse>>(cuentaList);
    //    }
    //}
}
