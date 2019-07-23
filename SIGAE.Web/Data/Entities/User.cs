namespace SIGAE.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;

    public class User : IdentityUser
    {
        [PersonalData]
        public Persona Persona { get; set; }

        public override string ToString()
        {
            return this.Email;
        }

        public string PersonaNombre()
        {
            return this.Persona.ToString();
        }
    }
}
