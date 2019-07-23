namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.ComponentModel.DataAnnotations;

    public class Nivel : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}