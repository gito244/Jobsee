using AutoMapper;
using Jobsee.Application.Features.Operaciones.Movimientos.Queries.GetMovimientosList;
using Jobsee.Application.Features.Operaciones.Movimientos.Queries.Vms;
using Jobsee.Application.Mappings;
using Jobsee.Application.UnitTests.Mock;
using Jobsee.Application.UnitTests.Mocks;
using Jobsee.Infrastructure.Repositories;
using Moq;
using Shouldly;
using Xunit;

namespace Jobsee.Application.UnitTests.Features.Movimientos_
{
    public class GetMovimientosListQueryHandlerXUnitTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<UnitOfWork> _unitOfWork;

        public GetMovimientosListQueryHandlerXUnitTests()
        {
            _unitOfWork = MockUnitOfWork.GetUnitOfWork();
            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<MappingProfile>();
            });
            _mapper = mapperConfig.CreateMapper();


            MockMovimientoRepository.AddDataMovimientoRepository(_unitOfWork.Object.DevsuDbContext);

        }

        [Fact]
        public async Task GetVideoListTest()
        {
            var handler = new GetMovimientosListQueryHandler(_unitOfWork.Object, _mapper);
            var request = new GetMovimientosListQuery()
            {
                Cliente = 1,
                FechaInicio = DateTime.Now,
                FechaFin = DateTime.Now
            };

            var result = await handler.Handle(request, CancellationToken.None);

            result.ShouldBeOfType<List<MovimientosWithIncludesVmResponse>>();
        }
    }
}
