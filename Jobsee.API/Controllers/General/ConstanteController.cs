using Jobsee.Application.Features.General.Constantes.Queries.GetAllConstantesList;
using Jobsee.Application.Features.General.Constantes.Queries.Vms;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Jobsee.API.Controllers.General
{
    [Route("api/v1/constante/[action]")]
    [ApiController]
    public class ConstanteController : Controller
    {
        #region Variables
        private IMediator _mediator;
        #endregion

        #region Constructor
        public ConstanteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Methods
        [HttpGet(Name = "getAllConstantes")]
        [Authorize(Policy = "RequiredAdministrator&Operator")]
        [ProducesResponseType(typeof(IEnumerable<ConstantesWithinIncludesVmResponse>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ConstantesWithinIncludesVmResponse>>> getAllConstantes()
        {
            var query = new GetAllConstantesListQuery();
            var constantes = await _mediator.Send(query);
            return Ok(constantes);
        }
        #endregion
    }
}
