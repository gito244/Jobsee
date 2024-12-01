//using Jobsee.Application.Features.Operaciones.Personas.Commands.CreatePersona;
//using Jobsee.Application.Features.Operaciones.Personas.Commands.DeletePersona;
//using Jobsee.Application.Features.Operaciones.Personas.Commands.UpdatePersona;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Jobsee.API.Controllers.Operaciones
{
    [Route("api/persona/[action]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        #region Variables
        private IMediator _mediator;
        #endregion

        #region Constructor
        public PersonaController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Methods
        //[HttpPost(Name = "CreatePersona")]
        //[Authorize(Policy = "RequiredAdministrator&Operator&RH")]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //public async Task<ActionResult<int>> CreatePersona([FromBody] CreatePersonaCommand command)
        //{
        //    return await _mediator.Send(command);
        //}

        //[HttpPut(Name = "UpdatePersona")]
        //[Authorize(Policy = "RequiredAdministrator&Operator&RH")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult> UpdatePersona([FromBody] UpdatePersonaCommand command)
        //{
        //    await _mediator.Send(command);

        //    return NoContent();
        //}

        //[HttpDelete("{id}", Name = "DeletePersona")]
        //[Authorize(Roles = "Administrator")]
        //[ProducesResponseType(StatusCodes.Status204NoContent)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        //public async Task<ActionResult> DeletePersona(int id)
        //{
        //    var command = new DeletePersonaCommand
        //    {
        //        PersonaId = id
        //    };

        //    await _mediator.Send(command);

        //    return NoContent();
        //}
        #endregion
    }
}
