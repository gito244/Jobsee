//using Jobsee.Application.Features.Operaciones.Movimientos.Commands.CreateMovimiento;
//using Jobsee.Application.Features.Operaciones.Movimientos.Commands.DeleteMovimiento;
//using Jobsee.Application.Features.Operaciones.Movimientos.Commands.UpdateMovimiento;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Jobsee.API.Controllers.Operaciones
{
    [Route("api/movimientos/[action]")]
    [ApiController]
    public class MovimientosController : ControllerBase
    {
        #region Variables
        private IMediator _mediator;
        #endregion

        #region Constructor
        public MovimientosController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Methods
        //[HttpPost(Name = "CreateMovimiento")]
        //[Authorize(Policy = "RequiredAdministrator&Operator")]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //public async Task<ActionResult<int>> CreateMovimiento([FromBody] CreateMovimientosCommand command)
        //{
        //    return await _mediator.Send(command);
        //}

        //[HttpPut(Name = "UpdateMovimiento")]
        //[Authorize(Policy = "RequiredAdministrator&Operator")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult> UpdateMovimiento([FromBody] UpdateMovimientoCommand command)
        //{
        //    await _mediator.Send(command);

        //    return NoContent();
        //}

        //[HttpDelete("{id}", Name = "DeleteMovimiento")]
        //[Authorize(Policy = "RequiredAdministrator&Operator")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult> DeleteMovimiento(int id)
        //{
        //    var command = new DeleteMovimientoCommand
        //    {
        //        MovimientoId = id
        //    };

        //    await _mediator.Send(command);

        //    return NoContent();
        //}
        #endregion
    }
}
