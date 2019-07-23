namespace SIGAE.Common.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Persona : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
    }
}
