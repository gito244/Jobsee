using Jobsee.Application.Contracts.Identity;
using Jobsee.Application.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jobsee.API.Controllers.Seguridad
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        #region Variables
        private readonly IAuthService _authService;
        #endregion

        #region Constructor
        public UsuarioController(IAuthService authService)
        {
            _authService = authService;
        }
        #endregion

        #region Methods
        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> login([FromBody] AuthRequest request)
        {
            return Ok(await _authService.Login(request));
        }

        [HttpPost("register")]
        public async Task<ActionResult<RegistrationResponse>> register([FromBody] RegistrationRequest request)
        {
            return Ok(await _authService.Register(request));
        }
        #endregion
    }
}
