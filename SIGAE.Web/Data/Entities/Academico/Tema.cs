namespace SIGAE.Web.Data.Entities.Academico
{
    using System.ComponentModel.DataAnnotations;

    public class Tema : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Asignatura Asignatura { get; set; }

        public override string ToString()
        {
            return $"{this.Nombre} - {this.Asignatura.Nombre}";
        }
    }
}
