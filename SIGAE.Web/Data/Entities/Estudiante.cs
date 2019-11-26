using SIGAE.Web.Data.Entities.Misc;

namespace SIGAE.Web.Data.Entities
{
    public class Estudiante : Persona, IEntity {
        public Etnia EtniaIndigena { get; set; }
    }
}