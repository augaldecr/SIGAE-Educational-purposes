namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.ComponentModel.DataAnnotations;

    //Aula, taller, plaza, patio
    public class TipoLocalizacion : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
