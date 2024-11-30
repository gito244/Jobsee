using AutoMapper;
using Jobsee.Application.Contracts.Persistence;
using Microsoft.Extensions.Logging;
using MediatR;
using Jobsee.Application.Exceptions;
using Jobsee.Domain.Operaciones;
using System.Runtime.InteropServices;

namespace Jobsee.Application.Features.Operaciones.Clientes.Commands.DeleteCliente
{
    public class DeleteClienteCommandHandler : IRequestHandler<DeleteClienteCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<DeleteClienteCommandHandler> _logger;

        public DeleteClienteCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<DeleteClienteCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        //public async Task<Unit> Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        //{
        //    var clienteToDelete = await _unitOfWork.ClienteRepository.GetByIdAsync(request.ClienteId);

        //    if (clienteToDelete == null)
        //    {
        //        _logger.LogError($"{request.ClienteId} cliente no existe en el sistema.");
        //        throw new NotFoundException(nameof(Cliente), request.ClienteId);
        //    }

        //    _unitOfWork.ClienteRepository.DeleteEntity(clienteToDelete);

        //    var personaToDelete = await _unitOfWork.PersonaRepository.GetByIdAsync(clienteToDelete.PersonaId);

        //    if (personaToDelete == null)
        //        _logger.LogError($"{personaToDelete!.PersonaId} persona no enontrada en el sistema.");
        //    else
        //        _unitOfWork.PersonaRepository.DeleteEntity(personaToDelete);

        //    await _unitOfWork.Transaction();

        //    _logger.LogInformation($"El {request.ClienteId} cliente fue eliminado con éxito.");

        //    return Unit.Value;
        //}

        async Task IRequestHandler<DeleteClienteCommand>.Handle(DeleteClienteCommand request, CancellationToken cancellationToken)
        {
            var clienteToDelete = await _unitOfWork.ClienteRepository.GetByIdAsync(request.ClienteId);

            if (clienteToDelete == null)
            {
                _logger.LogError($"{request.ClienteId} cliente no existe en el sistema.");
                throw new NotFoundException(nameof(Cliente), request.ClienteId);
            }

            _unitOfWork.ClienteRepository.DeleteEntity(clienteToDelete);

            var personaToDelete = await _unitOfWork.PersonaRepository.GetByIdAsync(clienteToDelete.PersonaId);

            if (personaToDelete == null)
                _logger.LogError($"{personaToDelete!.PersonaId} persona no enontrada en el sistema.");
            else
                _unitOfWork.PersonaRepository.DeleteEntity(personaToDelete);

            await _unitOfWork.Transaction();

            _logger.LogInformation($"El {request.ClienteId} cliente fue eliminado con éxito.");

            return ;
        }
    }
}
