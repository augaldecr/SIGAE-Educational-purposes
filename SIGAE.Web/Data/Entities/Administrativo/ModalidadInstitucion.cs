namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.ComponentModel.DataAnnotations;

    //Académica, Técnica, CINDEA
    public class ModalidadInstitucion
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}
