using Microsoft.AspNetCore.Identity;

namespace SIGAE.Web.Data.Entities
{
    public class User : IdentityUser
    {
        [PersonalData]
        public Persona Persona { get; set; }

        public override string ToString() => this.Email;

        public string PersonaNombre() => this.Persona.ToString();
    }
}