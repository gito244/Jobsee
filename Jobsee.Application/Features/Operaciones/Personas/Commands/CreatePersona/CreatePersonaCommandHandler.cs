﻿using AutoMapper;
using Jobsee.Application.Contracts.Infrastructure;
using Jobsee.Application.Contracts.Persistence;
using Jobsee.Domain.Operaciones;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Jobsee.Application.Features.Operaciones.Personas.Commands.CreatePersona
{
    //public class CreatePersonaCommandHandler : IRequestHandler<CreatePersonaCommand, int>
    //{
    //    private readonly IUnitOfWork _unitOfWork;
    //    private readonly IMapper _mapper;
    //    private readonly IEmailService _emailservice;
    //    private readonly ILogger<CreatePersonaCommandHandler> _logger;

    //    public CreatePersonaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IEmailService emailservice, ILogger<CreatePersonaCommandHandler> logger)
    //    {
    //        _unitOfWork = unitOfWork;
    //        _mapper = mapper;
    //        _emailservice = emailservice;
    //        _logger = logger;
    //    }

    //    public async Task<int> Handle(CreatePersonaCommand request, CancellationToken cancellationToken)
    //    {
    //        var personaEntity = _mapper.Map<Persona>(request);

    //        //_unitOfWork.PersonaRepository.AddEntity(personaEntity);

    //        //var result = await _unitOfWork.Transaction();

    //        //if (result <= 0)
    //        //{
    //        //    throw new Exception($"No se pudo insertar la persona.");
    //        //}

    //        //_logger.LogInformation($"Persona {personaEntity.PersonaId} fue creado existosamente");

    //        return personaEntity.PersonaId;
    //    }
    //}
}
