using AutoMapper;
using Jobsee.Application.Contracts.Infrastructure;
using Jobsee.Application.Features.Operaciones.Clientes.Commands.UpdateCliente;
using Jobsee.Application.Mappings;
using Jobsee.Application.UnitTests.Mock;
using Jobsee.Application.UnitTests.Mocks;
using Jobsee.Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using Shouldly;
using Xunit;

namespace Jobsee.Application.UnitTests.Features.Clientes.Commands.UpdateCliente
{
    public class UpdateClienteCommandHandlerXUnitTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<UnitOfWork> _unitOfWork;
        private readonly Mock<IEmailService> _emailService;
        private readonly Mock<ILogger<UpdateClienteCommandHandler>> _logger;

        public UpdateClienteCommandHandlerXUnitTest()
        {
            _unitOfWork = MockUnitOfWork.GetUnitOfWork();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();

            _emailService = new Mock<IEmailService>();

            _logger = new Mock<ILogger<UpdateClienteCommandHandler>>();


            MockClienteRepository.UpdateDataClienteRepository(_unitOfWork.Object.DevsuDbContext);
        }

        //[Fact]
        //public async Task UpdateClienteCommand_InputStreamer_ReturnsUnit()
        //{
        //    var ClienteInput = new UpdateClienteCommand
        //    {
        //        ClienteId = 1,
        //        Contrasena = "123",
        //        Estado = true
        //    };

        //    var handler = new UpdateClienteCommandHandler(_unitOfWork.Object, _mapper, _logger.Object);

        //    var result = await handler.Handle(ClienteInput, CancellationToken.None);
            
        //    result.ShouldBeOfType<Unit>();
        //}
    }
}
