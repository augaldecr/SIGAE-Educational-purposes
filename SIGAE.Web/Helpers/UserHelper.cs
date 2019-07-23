using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SIGAE.Web.Data.Entities;
using SIGAE.Web.Models;

namespace SIGAE.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IPersonaHelper personaHelper;

        public UserHelper(UserManager<User> userManager, SignInManager<User> signInManager, IPersonaHelper personaHelper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.personaHelper = personaHelper;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await this.userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            return await this.signInManager.PasswordSignInAsync(
                  model.Username,
                  model.Password,
                  model.RememberMe,
                  false);
        }

        public async Task LogoutAsync()
        {
            await this.signInManager.SignOutAsync();
        }

        public bool IsSigned(ClaimsPrincipal principal)
        {
            return this.signInManager.IsSignedIn(principal);
        }

        public async Task<IdentityResult> UpdateUserAsync(User user)
        {
            return await this.userManager.UpdateAsync(user);
        }     

        public async Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPasssword)
        {
            return await this.userManager.ChangePasswordAsync(user, oldPassword, newPasssword);
        }

        public async Task<SignInResult> ValidatePasswordAsync(User user, string password)
        {
            return await this.signInManager.CheckPasswordSignInAsync(
                user, password, false);
        }
    }
}
