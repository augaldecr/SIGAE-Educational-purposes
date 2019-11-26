using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Misc
{
    public class DialectoHablado : IEntity
    {
        public int Id { get; set; }
        [Required]
        public Dialecto Dialecto { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}