using Jobsee.Application.Models.Identity;

namespace Jobsee.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);
        Task<RegistrationResponse> Register(RegistrationRequest request);
        Task<AuthResponse> RefreshToken(TokenRequest request);
    }
}
