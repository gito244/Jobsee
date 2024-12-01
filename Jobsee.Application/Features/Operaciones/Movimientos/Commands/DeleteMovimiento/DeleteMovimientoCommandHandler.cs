using AutoMapper;
using Jobsee.Application.Contracts.Persistence.Operaciones;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Features.Operaciones.Personas.Commands.DeletePersona;
using MediatR;
using Microsoft.Extensions.Logging;
using Jobsee.Application.Exceptions;
using Jobsee.Domain.Operaciones;

namespace Jobsee.Application.Features.Operaciones.Movimientos.Commands.DeleteMovimiento
{
    //public class DeleteMovimientoCommandHandler : IRequestHandler<DeleteMovimientoCommand>
    //{
    //    private readonly IUnitOfWork _unitOfWork;
    //    private readonly IMovimientosRepository _movimientosRepository;
    //    private readonly IMapper _mapper;
    //    private readonly ILogger<DeletePersonaCommandHandler> _logger;

    //    public DeleteMovimientoCommandHandler(IUnitOfWork unitOfWork, IMovimientosRepository movimientosRepository, IMapper mapper, ILogger<DeletePersonaCommandHandler> logger)
    //    {
    //        _unitOfWork = unitOfWork;
    //        _movimientosRepository = movimientosRepository;
    //        _mapper = mapper;
    //        _logger = logger;
    //    }
    //    //public async Task<Unit> Handle(DeleteMovimientoCommand request, CancellationToken cancellationToken)
    //    //{
    //    //    var movimientoToDelete = await _unitOfWork.MovimientosRepository.GetByIdAsync(request.MovimientoId);

    //    //    if (movimientoToDelete == null)
    //    //    {
    //    //        _logger.LogError($"{request.MovimientoId} movimiento no existe en el sistema.");
    //    //        throw new NotFoundException(nameof(Domain.Operaciones.Movimientos), request.MovimientoId);
    //    //    }

    //    //    _unitOfWork.MovimientosRepository.DeleteEntity(movimientoToDelete);

    //    //    await _unitOfWork.Transaction();

    //    //    _logger.LogInformation($"El {request.MovimientoId} movimiento fue eliminado con exito.");

    //    //    return Unit.Value;
    //    //}

    //    async Task IRequestHandler<DeleteMovimientoCommand>.Handle(DeleteMovimientoCommand request, CancellationToken cancellationToken)
    //    {
    //        //var movimientoToDelete = await _unitOfWork.MovimientosRepository.GetByIdAsync(request.MovimientoId);

    //        //if (movimientoToDelete == null)
    //        //{
    //        //    _logger.LogError($"{request.MovimientoId} movimiento no existe en el sistema.");
    //        //    throw new NotFoundException(nameof(Domain.Operaciones.Movimientos), request.MovimientoId);
    //        //}

    //        //_unitOfWork.MovimientosRepository.DeleteEntity(movimientoToDelete);

    //        //await _unitOfWork.Transaction();

    //        //_logger.LogInformation($"El {request.MovimientoId} movimiento fue eliminado con exito.");
    //    }
    //}
}
