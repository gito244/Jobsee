using Jobsee.Application.Contracts.Identity;
using Jobsee.Application.Models.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jobsee.API.Controllers.Seguridad
{
    [Route("api/[controller]")]
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
        [HttpPost("Login")]
        public async Task<ActionResult<AuthResponse>> Login([FromBody] AuthRequest request)
        {
            return Ok(await _authService.Login(request));
        }

        [HttpPost("Register")]
        public async Task<ActionResult<RegistrationResponse>> Register([FromBody] RegistrationRequest request)
        {
            return Ok(await _authService.Register(request));
        }
        #endregion
    }
}
