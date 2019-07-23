namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.ComponentModel.DataAnnotations;
    //Docente, administrativo
    public class TipoPuesto : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}