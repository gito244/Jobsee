//using Jobsee.Application.Features.Operaciones.Movimientos.Queries.GetMovimientosList;
//using Jobsee.Application.Features.Operaciones.Movimientos.Queries.Vms;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Jobsee.API.Controllers.Operaciones
{
    [Route("api/reportes/[action]")]
    [ApiController]
    public class ReporteController : ControllerBase
    {
        #region Variables
        private IMediator _mediator;
        #endregion

        #region Constructor
        public ReporteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Methods
        //[HttpGet(Name = "GetRangoMovimientoByCliente")]
        //[Authorize(Policy = "RequiredAdministrator&Operator&Accountant")]
        //[ProducesResponseType(typeof(List<MovimientosWithIncludesVmResponse>), (int)HttpStatusCode.OK)]
        //public async Task<ActionResult<List<MovimientosWithIncludesVmResponse>>> GetRangoMovimientoByCliente(
        //        [FromQuery] GetMovimientosListQuery movimientosParams
        //    )
        //{
        //    var paginationVideo = await _mediator.Send(movimientosParams);
        //    return Ok(paginationVideo);
        //}
        #endregion
    }
}
