using WebApplicationClass.DTOs;
using static WebApplicationClass.DTOs.ServiceResponses;

namespace WebApplicationClass.Contracts
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDTO userDTO);
        Task<LoginResponse> LoginAccount(LoginDTO loginDTO);
    }
}
