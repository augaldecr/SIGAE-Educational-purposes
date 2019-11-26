using System.Collections.Generic;

namespace SIGAE.Web.Data.Entities.Administrativo.Asesoria
{
    //Desayuno, almuerzo, cena, hospedaje, etc
    public class TipoGasto : EntidadBase, IEntity
    {
        public virtual IList<Gasto> Gastos { get; }

        public override string ToString() => $"{this.Nombre}";
    }
}