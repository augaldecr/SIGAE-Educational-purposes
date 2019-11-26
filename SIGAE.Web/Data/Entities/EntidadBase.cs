using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities
{
    public abstract class EntidadBase : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}