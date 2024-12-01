﻿using AutoMapper;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Features.Operaciones.Clientes.Queries.GetAllClientesList;
using Jobsee.Application.Features.Operaciones.Cuentas.Queries.Vms;
using Jobsee.Domain.Operaciones;
using MediatR;
using System.Linq.Expressions;

namespace Jobsee.Application.Features.Operaciones.Cuentas.Queries.GetAllCuentasList
{
    //public class GetAllCuentasListQueryHandler : IRequestHandler<GetAllCuentasListQuery, List<CuentaWithIncludeVmResponse>>
    //{
    //    private readonly IUnitOfWork _unitOfWork;
    //    private readonly IMapper _mapper;

    //    public GetAllCuentasListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    //    {
    //        _unitOfWork = unitOfWork;
    //        _mapper = mapper;
    //    }

    //    public async Task<List<CuentaWithIncludeVmResponse>> Handle(GetAllCuentasListQuery request, CancellationToken cancellationToken)
    //    {
    //        var includes = new List<Expression<Func<Cuenta, object>>>();
    //        includes.Add(p => p.Cliente!);
    //        includes.Add(p => p.Cliente.Persona!);

    //        var cuentaList = await _unitOfWork.Repository<Cuenta>().GetAsync(
    //            b => b.NumeroCuenta >= 0,
    //            b => b.OrderBy(x => x.NumeroCuenta),
    //            includes,
    //            true
    //            );

    //        return _mapper.Map<List<CuentaWithIncludeVmResponse>>(cuentaList);
    //    }
    //}
}
