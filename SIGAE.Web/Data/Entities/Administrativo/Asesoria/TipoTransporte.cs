using System.Collections.Generic;

namespace SIGAE.Web.Data.Entities.Administrativo.Asesoria
{
    public class TipoTransporte : EntidadBase, IEntity
    {
        public virtual IList<Gira> Giras { get; }

        public override string ToString() => $"{this.Nombre}";
    }
}