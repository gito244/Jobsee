using AutoMapper;
using Jobsee.Application.Contracts.Persistence.Operaciones;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Application.Exceptions;
using Jobsee.Domain.Operaciones;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Jobsee.Application.Features.Operaciones.Personas.Commands.UpdatePersona
{
    public class UpdatePersonaCommandHandler : IRequestHandler<UpdatePersonaCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdatePersonaCommandHandler> _logger;

        public UpdatePersonaCommandHandler(IUnitOfWork unitOfWork, IPersonaRepository personaRepository, IMapper mapper, ILogger<UpdatePersonaCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _personaRepository = personaRepository;
            _mapper = mapper;
            _logger = logger;
        }

        //public async Task<Unit> Handle(UpdatePersonaCommand request, CancellationToken cancellationToken)
        //{
        //    var personaToUpdate = await _unitOfWork.PersonaRepository.GetByIdAsync(request.PersonaId);

        //    if (personaToUpdate == null)
        //    {
        //        _logger.LogError($"No se encontro la personaid {request.PersonaId}");
        //        throw new NotFoundException(nameof(Cliente), request.PersonaId);
        //    }

        //    _mapper.Map(request, personaToUpdate, typeof(UpdatePersonaCommand), typeof(Persona));

        //    _unitOfWork.PersonaRepository.UpdateEntity(personaToUpdate);

        //    await _unitOfWork.Transaction();

        //    _logger.LogInformation($"La operacion fue exitosa actualizando a la persona {request.PersonaId}");

        //    return Unit.Value;
        //}

        async Task IRequestHandler<UpdatePersonaCommand>.Handle(UpdatePersonaCommand request, CancellationToken cancellationToken)
        {
            //var personaToUpdate = await _unitOfWork.PersonaRepository.GetByIdAsync(request.PersonaId);

            //if (personaToUpdate == null)
            //{
            //    _logger.LogError($"No se encontro la personaid {request.PersonaId}");
            //    throw new NotFoundException(nameof(Cliente), request.PersonaId);
            //}

            //_mapper.Map(request, personaToUpdate, typeof(UpdatePersonaCommand), typeof(Persona));

            //_unitOfWork.PersonaRepository.UpdateEntity(personaToUpdate);

            //await _unitOfWork.Transaction();

            //_logger.LogInformation($"La operacion fue exitosa actualizando a la persona {request.PersonaId}");
        }
    }
}
