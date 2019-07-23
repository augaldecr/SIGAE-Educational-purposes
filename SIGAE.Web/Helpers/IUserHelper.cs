namespace SIGAE.Web.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using Data.Entities;
    using Models;
    using System.Threading.Tasks;
    using System.Security.Claims;

    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();
        bool IsSigned(ClaimsPrincipal principal);
        Task<IdentityResult> UpdateUserAsync(User user);
        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPasssword);
        Task<SignInResult> ValidatePasswordAsync(User user, string password);
    }
}
