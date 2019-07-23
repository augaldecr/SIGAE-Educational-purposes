namespace SIGAE.Web.Data.Entities.Academico
{
    using System.ComponentModel.DataAnnotations;
    public class Especialidad : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        //Comercio y de servicios, Agricultura
        [Required]
        public Modalidad Modalidad { get; set; }
    }
}
