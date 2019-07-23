namespace SIGAE.Web.Data.Entities.Misc
{
    using System.ComponentModel.DataAnnotations;

    public class Archivo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string URL { get; set; }
    }
}
