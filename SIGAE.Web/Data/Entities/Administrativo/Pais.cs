using System.Collections.Generic;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    public class Pais : EntidadBase, IEntity
    {
        public virtual IEnumerable<Provincia> Provincias { get; set; }
    }
}