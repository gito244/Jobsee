using Jobsee.Application.Features.Operaciones.Cuentas.Commands.CreateCuenta;
using Jobsee.Application.Features.Operaciones.Cuentas.Commands.DeleteCuenta;
using Jobsee.Application.Features.Operaciones.Cuentas.Commands.UpdateCuenta;
using Jobsee.Application.Features.Operaciones.Cuentas.Queries.GetAllCuentasList;
using Jobsee.Application.Features.Operaciones.Cuentas.Queries.GetCuentasList;
using Jobsee.Application.Features.Operaciones.Cuentas.Queries.Vms;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Jobsee.API.Controllers.Operaciones
{
    [Route("api/cuentas/[action]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        #region Variables
        private IMediator _mediator;
        #endregion

        #region Constructor
        public CuentaController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Methods
        [HttpGet(Name = "GetAllCuentas")]
        [Authorize(Policy = "RequiredAdministrator&Operator")]
        [ProducesResponseType(typeof(IEnumerable<CuentaWithIncludeVmResponse>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<CuentaWithIncludeVmResponse>>> GetAllCuentas()
        {
            var query = new GetAllCuentasListQuery();
            var cuentas = await _mediator.Send(query);
            return Ok(cuentas);
        }

        [HttpGet("{numeroCuenta}", Name = "GetCuentaByNumero")]
        [Authorize(Policy = "RequiredAdministrator&Operator")]
        [ProducesResponseType(typeof(IEnumerable<CuentaWithIncludeVmResponse>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<CuentaWithIncludeVmResponse>>> GetCuentaByNumero(int numeroCuenta)
        {
            var query = new GetCuentaListQuery(numeroCuenta);
            var cuentas = await _mediator.Send(query);
            return Ok(cuentas);
        }

        [HttpPost(Name = "CreateCuenta")]
        [Authorize(Policy = "RequiredAdministrator&Operator")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateCuenta([FromBody] CreateCuentaCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut(Name = "UpdateCuenta")]
        [Authorize(Policy = "RequiredAdministrator&Operator")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateCuenta([FromBody] UpdateCuentaCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteCuenta")]
        [Authorize(Policy = "RequiredAdministrator&Operator")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteCuenta(int id)
        {
            var command = new DeleteCuentaCommand
            {
                NumeroCuenta = id
            };

            await _mediator.Send(command);

            return NoContent();
        }
        #endregion
    }
}
