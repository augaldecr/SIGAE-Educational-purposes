namespace SIGAE.Common.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Template : IEntity
    {
        public int Id { get; set; }
        public Persona Persona { get; set; }
        [Required]
        public string Plantilla { get; set; }
    }
}
