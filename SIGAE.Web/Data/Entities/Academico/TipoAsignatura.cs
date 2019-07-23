namespace SIGAE.Web.Data.Entities.Academico
{
    using System.ComponentModel.DataAnnotations;

    //Básica, Complementaria, Técnica, Ciencia, Conducta
    public class TipoAsignatura : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
