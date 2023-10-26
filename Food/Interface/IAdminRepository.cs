using Food.Dto_s;
namespace Food.Interface;

public interface IAdminRepository
{
    Task<UserDto> CreateAdmin(UserDto user);
    Task<UserDto> CreateOwner(UserDto user);

}