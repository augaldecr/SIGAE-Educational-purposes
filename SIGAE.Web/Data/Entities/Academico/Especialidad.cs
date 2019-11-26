using System.ComponentModel.DataAnnotations;

namespace SIGAE.Web.Data.Entities.Academico
{
    public class Especialidad : EntidadBase, IEntity
    {
        //Comercio y de servicios, Agricultura
        [Required]
        public Modalidad Modalidad { get; set; }
    }
}