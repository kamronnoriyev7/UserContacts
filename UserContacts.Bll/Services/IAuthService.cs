using UserContacts.Bll.Dtos;

namespace UserContacts.Bll.Services;

public interface IAuthService
{
    Task<long> SignUpUserAsync(UserCreateDto userCreateDto);
    Task<LoginResponseDto> LoginUserAsync(UserLoginDto userLoginDto);
    Task LogOut(string token);
   
    Task<LoginResponseDto> RefreshTokenAsync(RefreshRequestDto request);
}