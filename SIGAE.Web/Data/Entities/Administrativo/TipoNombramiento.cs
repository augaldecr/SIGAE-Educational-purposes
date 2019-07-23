namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.ComponentModel.DataAnnotations;

    //Interino, Propiedad
    public class TipoNombramiento : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}