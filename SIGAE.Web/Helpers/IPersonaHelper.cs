using SIGAE.Web.Data.Entities;

namespace SIGAE.Web.Helpers
{
    public interface IPersonaHelper
    {
        Persona GetPersonaXCedula(string cedula);
        void SavePersona(Persona persona);
        void UpdatePersona(Persona persona);
        Persona GetPersonaXEmail(string email);
    }
}