using NestSecure.AuthService.Dtos;

namespace NestSecure.AuthService.Services
{
    public interface IAuthService
    {
        Task<AuthResponseDto> LoginAsync(LoginDto loginDto);

    }
}
