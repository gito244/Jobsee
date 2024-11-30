﻿using AutoMapper;
using Jobsee.Application.Contracts.Persistence.Operaciones;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Features.Operaciones.Clientes.Commands.UpdateCliente;
using Microsoft.Extensions.Logging;
using MediatR;
using Jobsee.Application.Exceptions;
using Jobsee.Domain.Operaciones;

namespace Jobsee.Application.Features.Operaciones.Cuentas.Commands.UpdateCuenta
{
    public class UpdateCuentaCommandHandler : IRequestHandler<UpdateCuentaCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICuentaRepository _cuentaRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateClienteCommandHandler> _logger;

        public UpdateCuentaCommandHandler(IUnitOfWork unitOfWork, ICuentaRepository cuentaRepository, IMapper mapper, ILogger<UpdateClienteCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _cuentaRepository = cuentaRepository;
            _mapper = mapper;
            _logger = logger;
        }

        //public async Task<Unit> Handle(UpdateCuentaCommand request, CancellationToken cancellationToken)
        //{
        //    var cuentaToUpdate = await _unitOfWork.CuentaRepository.GetByIdAsync(request.NumeroCuenta);

        //    if (cuentaToUpdate == null)
        //    {
        //        _logger.LogError($"No se encontro el numero de cuenta {request.NumeroCuenta}");
        //        throw new NotFoundException(nameof(Cliente), request.NumeroCuenta);
        //    }

        //    _mapper.Map(request, cuentaToUpdate, typeof(UpdateClienteCommand), typeof(Cliente));

        //    _unitOfWork.CuentaRepository.UpdateEntity(cuentaToUpdate);

        //    await _unitOfWork.Transaction();

        //    _logger.LogInformation($"La operacion fue exitosa actualizando el numero de cuenta {request.NumeroCuenta}");

        //    return Unit.Value;
        //}

        async Task IRequestHandler<UpdateCuentaCommand>.Handle(UpdateCuentaCommand request, CancellationToken cancellationToken)
        {
            var cuentaToUpdate = await _unitOfWork.CuentaRepository.GetByIdAsync(request.NumeroCuenta);

            if (cuentaToUpdate == null)
            {
                _logger.LogError($"No se encontro el numero de cuenta {request.NumeroCuenta}");
                throw new NotFoundException(nameof(Cliente), request.NumeroCuenta);
            }

            _mapper.Map(request, cuentaToUpdate, typeof(UpdateClienteCommand), typeof(Cliente));

            _unitOfWork.CuentaRepository.UpdateEntity(cuentaToUpdate);

            await _unitOfWork.Transaction();

            _logger.LogInformation($"La operacion fue exitosa actualizando el numero de cuenta {request.NumeroCuenta}");

            return ;
        }
    }
}
