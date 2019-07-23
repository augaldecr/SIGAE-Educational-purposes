using SIGAE.Web.Data.Entities.Administrativo;

namespace SIGAE.Web.Data.Entities.Inventario
{
    //Lugar específico de la institución donde se encuentra el item
    public class Localizacion : IEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Institucion Institucion { get; set; }
    }
}
