using PrintKmBack.Dtos;

namespace PrintKmBack.Services.Interfaces;

public interface IAuthService
{
    Task<LoginResponse?> LoginAsync(LoginRequest request);
    Task<LoginResponse?> RefreshAsync(RefreshTokenRequest request);
}
