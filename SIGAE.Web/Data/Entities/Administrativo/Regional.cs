using System.Collections.Generic;

namespace SIGAE.Web.Data.Entities.Administrativo
{
    public class Regional : EntidadBase, IEntity
    {
        public virtual IEnumerable<Circuito> Circuitos { get; set; }
    }
}