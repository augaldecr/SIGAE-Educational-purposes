namespace SIGAE.Web.Data.Entities.Administrativo
{
    //Docente, administrativo
    public class TipoPuesto : EntidadBase, IEntity
    {
        public override string ToString() => this.Nombre;
    }
}