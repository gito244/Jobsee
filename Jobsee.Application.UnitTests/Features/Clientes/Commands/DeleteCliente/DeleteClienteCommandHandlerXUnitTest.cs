using AutoMapper;
using Jobsee.Application.Features.Operaciones.Clientes.Commands.DeleteCliente;
using Jobsee.Application.Mappings;
using Jobsee.Application.UnitTests.Mock;
using Jobsee.Application.UnitTests.Mocks;
using Jobsee.Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;
using Moq;
using Shouldly;
using Xunit;

namespace Jobsee.Application.UnitTests.Features.Clientes.Commands.DeleteCliente
{
    public class DeleteClienteCommandHandlerXUnitTest
    {
        private readonly IMapper _mapper;
        private readonly Mock<UnitOfWork> _unitOfWork;
        private readonly Mock<ILogger<DeleteClienteCommandHandler>> _logger;

        public DeleteClienteCommandHandlerXUnitTest()
        {
            _unitOfWork = MockUnitOfWork.GetUnitOfWork();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();

            _logger = new Mock<ILogger<DeleteClienteCommandHandler>>();

            MockClienteRepository.DeleteDataClienteRepository(_unitOfWork.Object.DevsuDbContext);
        }

        //[Fact]
        //public async Task DeleteClienteCommand_InputStreamer_ReturnsUnit()
        //{
        //    var clienteInput = new DeleteClienteCommand
        //    {
        //        ClienteId = 1
        //    };

        //    var handler = new DeleteClienteCommandHandler(_unitOfWork.Object, _mapper, _logger.Object);

        //    var result = await handler.Handle(clienteInput, CancellationToken.None);

        //    result.ShouldBeOfType<Unit>();
        //}
    }
}
