using SIGAE.Web.Data.Entities;

namespace SIGAE.Web.Helpers
{
    public interface IIdentificacionHelper
    {
        Identificacion GetIdentificacionXCedula(string cedula);
        Identificacion GetIdentificacion(int id);
        void SaveIdentificacion(Identificacion identificacion);
        void UpdateIdentificacion(Identificacion identificacion);
    }
}