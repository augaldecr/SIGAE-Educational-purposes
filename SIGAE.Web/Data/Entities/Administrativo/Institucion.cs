namespace SIGAE.Web.Data.Entities.Administrativo
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations; 

    public class Institucion : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string CodigoPresupuestario { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Circuito Circuito { get; set; }
        //Pueblo, ciudad, barrio
        [Required]
        public Localidad Localidad { get; set; }
        [Required]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Required]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }
        [Required]
        [Display(Name = "Correo electrónico")]
        public string Email { get; set; }
        public string Lema { get; set; }
        [Display(Name = "Logo")]
        public string LogoURL { get; set; }
        [Display(Name = "Misión")]
        public string Mision { get; set; }
        [Display(Name = "Visión")]
        public string Vision { get; set; }
        //Académica, Técnica, CINDEA
        [Required]
        public ModalidadInstitucion Modalidad { get; set; }
        //Preescolar, I & II ciclos, III ciclo, Educación diversificada
        [Required]
        [Display(Name = "Tipo de institución")]
        public TipoInstitucion TipoInstitucion { get; set; }

        public virtual IEnumerable<Grupo> Grupos { get; set; }
    }
}
