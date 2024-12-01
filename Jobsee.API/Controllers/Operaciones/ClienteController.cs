//using Jobsee.Application.Features.Operaciones.Clientes.Commands.CreateCliente;
//using Jobsee.Application.Features.Operaciones.Clientes.Commands.DeleteCliente;
//using Jobsee.Application.Features.Operaciones.Clientes.Commands.UpdateCliente;
//using Jobsee.Application.Features.Operaciones.Clientes.Queries.GetAllClientesList;
//using Jobsee.Application.Features.Operaciones.Clientes.Queries.GetClientesList;
//using Jobsee.Application.Features.Operaciones.Clientes.Queries.Vms;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Jobsee.API.Controllers.Operaciones
{
    [Route("api/clientes/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        #region Variables
        private IMediator _mediator;
        #endregion

        #region Constructor
        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Methods

        //[HttpGet(Name = "GetAllClientes")]
        //[Authorize(Policy = "RequiredAdministrator&Operator")]
        //[ProducesResponseType(typeof(IEnumerable<ClienteWithIncludeVmResponse>), (int)HttpStatusCode.OK)]
        //public async Task<ActionResult<IEnumerable<ClienteWithIncludeVmResponse>>> GetAllClientes()
        //{
        //    var query = new GetAllClientesListQuery();
        //    var clientes = await _mediator.Send(query);
        //    return Ok(clientes);
        //}

        //[HttpGet("{cliente}", Name = "GetClientesByCliente")]
        //[Authorize(Policy = "RequiredAdministrator&Operator")]
        //[ProducesResponseType(typeof(IEnumerable<ClienteWithIncludeVmResponse>), (int)HttpStatusCode.OK)]
        //public async Task<ActionResult<IEnumerable<ClienteWithIncludeVmResponse>>> GetClientesByCliente(int cliente)
        //{
        //    var query = new GetClienteListQuery(cliente);
        //    var clientes = await _mediator.Send(query);
        //    return Ok(clientes);
        //}

        //[HttpPost(Name = "CreateCliente")]
        //[Authorize(Policy = "RequiredAdministrator&Operator")]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //public async Task<ActionResult<int>> CreateCliente([FromBody] CreateClienteCommand command)
        //{
        //    return await _mediator.Send(command);
        //}

        //[HttpPut(Name = "UpdateCliente")]
        //[Authorize(Policy = "RequiredAdministrator&Operator")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult> UpdateCliente([FromBody] UpdateClienteCommand command)
        //{
        //    await _mediator.Send(command);

        //    return NoContent();
        //}

        //[HttpDelete("{id}", Name = "DeleteCliente")]
        //[Authorize(Roles = "Administrator")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult> DeleteCliente(int id)
        //{
        //    var command = new DeleteClienteCommand
        //    {
        //        ClienteId = id
        //    };

        //    await _mediator.Send(command);

        //    return NoContent();
        //}

        #endregion
    }
}
