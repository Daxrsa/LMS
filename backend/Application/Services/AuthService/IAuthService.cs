using Application.Core;
using Domain.Entities;

namespace Application.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<Guid>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string email, string password);
        Task<bool> UserExists(string email);
    }
}