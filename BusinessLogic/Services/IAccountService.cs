using BusinessLogic.DTO;

namespace BusinessLogic.Services;

public interface IAccountService
{
    void CreateUser(CreateUserDTO createUserDto);
}