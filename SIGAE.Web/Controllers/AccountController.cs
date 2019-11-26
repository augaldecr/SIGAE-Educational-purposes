namespace SIGAE.Web.Controllers
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using SIGAE.Web.Data.Entities;
    using SIGAE.Web.Helpers;
    using SIGAE.Web.Models;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    public class AccountController : Controller
    {
        private readonly IUserHelper userHelper;
        private readonly IPersonaHelper personaHelper;
        private readonly IConfiguration configuration;
        private readonly IdentificacionHelper identificacionHelper;

        public AccountController(IUserHelper userHelper, 
            IPersonaHelper personaHelper, 
            IConfiguration configuration,
            IdentificacionHelper identificacionHelper)
        {
            this.userHelper = userHelper;
            this.personaHelper = personaHelper;
            this.configuration = configuration;
            this.identificacionHelper = identificacionHelper;
        }

        public IActionResult Login()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToAction("Index", "Home");
            }
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var result = await this.userHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (this.Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return this.Redirect(this.Request.Query["ReturnUrl"].First());
                    }
                    return this.RedirectToAction("Index", "Home");
                }
            }
            this.ModelState.AddModelError(string.Empty, "Error al ingresar.");
            return this.View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await this.userHelper.LogoutAsync();
            return this.RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterNewUserViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await userHelper.GetUserByEmailAsync(model.Username).ConfigureAwait(false);

                if (user == null)
                {
                    personaHelper.SavePersona(new Persona {
                        Identificacion = new Identificacion { NumIdentificacion = model.Cedula },
                        Nombre = model.Nombre,
                        Apellido1 = model.Apellido1,
                        Apellido2 = model.Apellido2,
                        Celular = model.Celular,
                        Email = model.Username
                    });

                    var persona = personaHelper.GetPersonaXCedula(model.Cedula);

                    user = new User
                    {
                        Persona = persona,
                        Email = model.Username,
                        UserName = model.Username
                    };

                    var result = await userHelper.AddUserAsync(user, model.Password).ConfigureAwait(false);

                    if (result != IdentityResult.Success)
                    {
                        this.ModelState.AddModelError(string.Empty, "El usuario no pudo ser creado");
                        return this.View(model);
                    }

                    var result2 = await userHelper.LoginAsync(
                        new LoginViewModel {
                            Username = model.Username,
                            Password = model.Password,
                            RememberMe = false
                        }).ConfigureAwait(false);

                    if (result2.Succeeded)
                    {
                        return this.RedirectToAction("Index", "Home");
                    }

                    this.ModelState.AddModelError(string.Empty, "El usuario no ha podido ingresar");
                    return this.View(model);
                }
                this.ModelState.AddModelError(string.Empty, "El usuario ya se ha registrado previamente");
            }
            return this.View(model);
        }

        public async Task<IActionResult> ChangeUser()
        {
            var user = await userHelper.GetUserByEmailAsync(User.Identity.Name).ConfigureAwait(false);
            var persona = this.personaHelper.GetPersonaXEmail(this.User.Identity.Name);

            var model = new ChangeUserViewModel();
            if (user != null)
            {
                model.Cedula = persona.Identificacion.NumIdentificacion;
                model.Nombre = persona.Nombre;
                model.Apellido1 = persona.Apellido1;
                model.Apellido2 = persona.Apellido2;
                model.Celular = persona.Celular;
            }
            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangeUser(ChangeUserViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await userHelper.GetUserByEmailAsync(User.Identity.Name).ConfigureAwait(false);
                var persona = this.personaHelper.GetPersonaXEmail(this.User.Identity.Name);
                var cedula = identificacionHelper.GetIdentificacionXCedula(model.Cedula);


                if (user != null)
                {
                    persona.Identificacion = cedula;
                    persona.Nombre = model.Nombre;
                    persona.Apellido1 = model.Apellido1;
                    persona.Apellido2 = model.Apellido2;
                    persona.Celular = model.Celular;

                    try
                    {
                        this.personaHelper.UpdatePersona(persona);
                        this.ViewBag.UserMessage = "Usuario actualizado";
                    }
                    catch (Exception e)
                    {
                        this.ModelState.AddModelError(string.Empty, e.Message);
                        throw new Exception(e.ToString());
                    }
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, "Usuario no encontrado");
                }
            }
            return this.View(model);
        }  

        public IActionResult ChangePassword()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await this.userHelper.GetUserByEmailAsync(this.User.Identity.Name);
                if (user != null)
                {
                    var result = await this.userHelper.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
                    if (result.Succeeded)
                    {
                        this.ViewBag.UserMessage = "Contraseña actualizada";
                        return this.RedirectToAction("ChangeUser");
                    }
                    else
                    {
                        this.ModelState.AddModelError(string.Empty, result.Errors.FirstOrDefault().Description);
                    }
                }
                else
                {
                    this.ModelState.AddModelError(string.Empty, "Usuario no encontrado");
                }
            }
            return this.View(model);
        }
         
        [HttpPost]
        public async Task<IActionResult> CreateToken([FromBody] LoginViewModel model)
        {
            if (this.ModelState.IsValid)
            {
                var user = await userHelper.GetUserByEmailAsync(User.Identity.Name).ConfigureAwait(false);
                if (user != null)
                {
                    var result = await userHelper.ValidatePasswordAsync(user, model.Password).ConfigureAwait(false);
                    if (result.Succeeded)
                    {
                        var claims = new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                        };

                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["Tokens:Key"]));
                        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(
                            this.configuration["Tokens:Issuer"],
                            this.configuration["Tokens:Audience"],
                            claims,
                            expires: DateTime.UtcNow.AddDays(15),
                            signingCredentials: credentials);
                        var results = new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token),
                            expiration = token.ValidTo
                        };

                        return Created(string.Empty, results);
                    }
                }
            }
            return this.BadRequest();
        }
    }
}